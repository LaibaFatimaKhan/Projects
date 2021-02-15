patches-own [value pollution]
globals [max-plastic]
breed [fishermen fisherman]
breed [foods food]
breed [fishes fish]
breed [mps mp]
fishes-own[energy plastic age]
fishermen-own [catch]

to setup
  ca
  fishing


  ask patches with [ pxcor >= -9 and pxcor <= 9]
  [ set pcolor 86 ] ;cyan for shallow water
  ask patches with [ pxcor >= 9 ]
  [ set pcolor blue ] ;dark blue for deep water
  ask patches with [ pxcor < -9 ]
  [   set pcolor 42] ;brown for land (area for land is less because water is the main area of action)

  ask patches
  [
    if pxcor = -10
    [
      if pycor < -12
      [set plabel "R"  ;; microplastic source1: Rivers which contain sewage as well
       set pcolor red]
      if pycor > 12
      [set plabel "I"  ;; microplastic source2: Industries
       set pcolor red]
      if pycor <= 1 and pycor >= -1
      [set plabel "S"  ;; microplastic source3: Dumped on the beach by people
       set pcolor red]
    ]
  ]

  ;Fishes in Sea
  create-fishes number-of-initial-fish
  [
    set xcor -9 + random 25
    set ycor -15 + random 31

    set shape "fish"
    set color orange + random 3
    set energy random 100
    set age random 10
  ]

  create-foods initial-food
  [
    set shape "circle"
    set xcor  -9 + random 25
    set ycor -15 + random 31
    set color black
    set size .3
  ]


  set max-plastic 20
  reset-ticks


end

to go

  dump-plastic

  move
  eat
  fish-aging
  reproduce
  diee
  catch-fish


  if count fishes = 0
  [
    stop
  ]

  tick

end

to dump-plastic
  set-default-shape mps "triangle"
  create-mps prob-river * 100
  [
    set xcor -9
    set ycor -15
    set color white
    set size .3
  ]
  create-mps prob-industrial * 100
  [
    set xcor -9
    set ycor 15
    set color white
    set size .3
  ]
  create-mps prob-beach * 100 [

    set xcor -9
    set ycor 0
    set color white
    set size .3
  ]
end

to move
  ask fishes
  [
    ifelse pxcor > -9
    [
      right random 360
      ifelse energy > 50
      [fd .3] []
    ]

    [ move-to patch -8 random-ycor
      right random 180
      ifelse energy > 50
      [fd .3] []

    ]

      set energy energy - 2
  ]
  ask mps
  [
    ifelse pxcor > -9
    [
      right random 360
      fd 5
    ]

    [ move-to patch -8 random-ycor
      right random 180
      fd 5

    ]
  ]
  ask foods
  [
    ifelse pxcor > -9
    [
      right random 360
    fd 1
    ]

    [ move-to patch -8 random-ycor
      right random 180
      fd 1

    ]
  ]
end

;;cite visual evolution model
to eat
  ask fishes
  [
    let p nobody;

    ifelse plastic > 3 ;;fish think plastic is food. Probability of eating plastic is high
    [
      ifelse random 4 > 3
       [
        set p min-one-of foods [distance myself]
        set energy energy + 6
      ]
      [   set p min-one-of mps [distance myself]
          set plastic plastic + 1
          set energy energy - 20
      ]
    ]
    [
      ifelse random 4 > 0
      [
        set p min-one-of foods [distance myself]
        set energy energy + 12
        ;;with every 1g of carbohydratefish obtain an energy of approximately 3.86 kcal.We are assuming every food particle to be 3gm
         ;;http://www.fao.org/3/x5738e/x5738e03.html
      ]
      [   set p min-one-of mps [distance myself]
          set plastic plastic + 1
          set energy energy - 20
      ]
    ]

    if  p != nobody
    [
      face p
      fd 1
      ask p
      [ die ]
      replenish-food
    ]
  ]
end

to replenish-food
  if random 1 <= food-replenish-rate
  [
    hatch-foods 1
    [
      set color black
      set shape "circle"
      set size .3
      set xcor -9 + random 25
      set ycor -15 + random 31
    ]
  ]
end

to   reproduce
  ;fish reproduce
  ask fishes
  [
    let mps-mom plastic
    if age > 4 and energy > 100 and plastic < 10
    [
    ;;Some fish can begin reproducing immediately after birth, while others may take years to mature.
    ;;https://www.petful.com/misc/how-do-fish-mate/
    ;;in this model the fish are reproducing after 4 weeks of age
      hatch-fishes random max-birth-count
      [
        set xcor -9 + random 25
        set ycor -15 + random 31
        set shape "fish"
        set color orange + random 3
        set energy 10
        set age 0
        set plastic mps-mom
      ]
      set energy energy / 2
    ]
  ]
end


to fish-aging
  ask fishes
  [
    set age age + 1
  ]
end


to fishing

  create-fishermen number-of-fishermen [
    set shape "boat top"
    setxy -15 random-ycor
    set heading 90
    set size 2
    set catch 0
  ]

end


to diee
  ask fishes
  [
  if plastic >= max-plastic or age >= max-age or energy <= 0
  [
      die
  ]
  ]
end


to catch-fish
  ask fishermen [
    fd 3
    if pxcor  = 15
    [

     set heading 270

    ]


  ifelse catch !=  fish-catch [
    let p any? fishes in-radius 1

    if p = True
    [let d count fishes in-radius 1
      set   catch catch + d
      ask fishes in-radius 1 [

        die
  ]
      ]

    ]
      [
      set heading 270
      fd 3
  ]

      if pxcor = -15 and catch <  fish-catch [
      set heading 90 ]

  ]
end
@#$#@#$#@
GRAPHICS-WINDOW
220
10
848
639
-1
-1
20.0
1
10
1
1
1
0
0
0
1
-15
15
-15
15
0
0
1
ticks
30.0

BUTTON
101
63
164
96
setup
setup
NIL
1
T
OBSERVER
NIL
NIL
NIL
NIL
1

SLIDER
27
262
199
295
number-of-initial-fish
number-of-initial-fish
1
500
130.0
1
1
NIL
HORIZONTAL

BUTTON
101
110
164
143
go
go
T
1
T
OBSERVER
NIL
NIL
NIL
NIL
0

PLOT
1063
26
1263
176
Fish in water
time
fish count
0.0
300.0
0.0
500.0
true
false
"" ""
PENS
"default" 1.0 0 -16777216 true "" "plot count fishes"

PLOT
877
282
1319
444
Percentage of pollutants in water
time
Percentage of polluted patches
0.0
300.0
0.0
100.0
true
false
"" ""
PENS
"pen-3" 1.0 0 -16777216 true "" "plot (count mps )"

SLIDER
27
312
199
345
energy-from-food
energy-from-food
0
100
10.0
1
1
NIL
HORIZONTAL

SLIDER
26
360
198
393
food-replenish-rate
food-replenish-rate
0
1
0.7
.1
1
NIL
HORIZONTAL

SLIDER
29
414
201
447
prob-river
prob-river
0
1
0.6
.1
1
NIL
HORIZONTAL

SLIDER
26
462
198
495
prob-industrial
prob-industrial
0
1
0.6
.1
1
NIL
HORIZONTAL

SLIDER
24
516
198
549
prob-beach
prob-beach
0
1
0.2
.1
1
NIL
HORIZONTAL

SLIDER
26
211
198
244
initial-food
initial-food
0
500
60.0
1
1
NIL
HORIZONTAL

SLIDER
26
575
198
608
max-birth-count
max-birth-count
0
20
5.0
1
1
NIL
HORIZONTAL

SLIDER
27
616
199
649
max-age
max-age
52
520
100.0
1
1
weeks
HORIZONTAL

MONITOR
876
36
943
81
fish count
count fishes
17
1
11

MONITOR
877
99
988
144
microplastic count
count mps
17
1
11

SLIDER
871
168
1043
201
number-of-fishermen
number-of-fishermen
1
30
5.0
1
1
NIL
HORIZONTAL

SLIDER
873
222
1045
255
fish-catch
fish-catch
0
100
40.0
1
1
NIL
HORIZONTAL

@#$#@#$#@
## WHAT IS IT?

(a general understanding of what the model is trying to show or explain)

## HOW IT WORKS

(what rules the agents use to create the overall behavior of the model)

## HOW TO USE IT

(how to use the model, including a description of each of the items in the Interface tab)

## THINGS TO NOTICE

(suggested things for the user to notice while running the model)

## THINGS TO TRY

(suggested things for the user to try to do (move sliders, switches, etc.) with the model)

## EXTENDING THE MODEL

(suggested things to add or change in the Code tab to make the model more complicated, detailed, accurate, etc.)

## NETLOGO FEATURES

(interesting or unusual features of NetLogo that the model uses, particularly in the Code tab; or where workarounds were needed for missing features)

## RELATED MODELS

(models in the NetLogo Models Library and elsewhere which are of related interest)

## CREDITS AND REFERENCES

(a reference to the model's URL on the web if it has one, as well as any other necessary credits, citations, and links)
@#$#@#$#@
default
true
0
Polygon -7500403 true true 150 5 40 250 150 205 260 250

airplane
true
0
Polygon -7500403 true true 150 0 135 15 120 60 120 105 15 165 15 195 120 180 135 240 105 270 120 285 150 270 180 285 210 270 165 240 180 180 285 195 285 165 180 105 180 60 165 15

arrow
true
0
Polygon -7500403 true true 150 0 0 150 105 150 105 293 195 293 195 150 300 150

boat top
true
0
Polygon -7500403 true true 150 1 137 18 123 46 110 87 102 150 106 208 114 258 123 286 175 287 183 258 193 209 198 150 191 87 178 46 163 17
Rectangle -16777216 false false 129 92 170 178
Rectangle -16777216 false false 120 63 180 93
Rectangle -7500403 true true 133 89 165 165
Polygon -11221820 true false 150 60 105 105 150 90 195 105
Polygon -16777216 false false 150 60 105 105 150 90 195 105
Rectangle -16777216 false false 135 178 165 262
Polygon -16777216 false false 134 262 144 286 158 286 166 262
Line -16777216 false 129 149 171 149
Line -16777216 false 166 262 188 252
Line -16777216 false 134 262 112 252
Line -16777216 false 150 2 149 62

box
false
0
Polygon -7500403 true true 150 285 285 225 285 75 150 135
Polygon -7500403 true true 150 135 15 75 150 15 285 75
Polygon -7500403 true true 15 75 15 225 150 285 150 135
Line -16777216 false 150 285 150 135
Line -16777216 false 150 135 15 75
Line -16777216 false 150 135 285 75

bug
true
0
Circle -7500403 true true 96 182 108
Circle -7500403 true true 110 127 80
Circle -7500403 true true 110 75 80
Line -7500403 true 150 100 80 30
Line -7500403 true 150 100 220 30

butterfly
true
0
Polygon -7500403 true true 150 165 209 199 225 225 225 255 195 270 165 255 150 240
Polygon -7500403 true true 150 165 89 198 75 225 75 255 105 270 135 255 150 240
Polygon -7500403 true true 139 148 100 105 55 90 25 90 10 105 10 135 25 180 40 195 85 194 139 163
Polygon -7500403 true true 162 150 200 105 245 90 275 90 290 105 290 135 275 180 260 195 215 195 162 165
Polygon -16777216 true false 150 255 135 225 120 150 135 120 150 105 165 120 180 150 165 225
Circle -16777216 true false 135 90 30
Line -16777216 false 150 105 195 60
Line -16777216 false 150 105 105 60

car
false
0
Polygon -7500403 true true 300 180 279 164 261 144 240 135 226 132 213 106 203 84 185 63 159 50 135 50 75 60 0 150 0 165 0 225 300 225 300 180
Circle -16777216 true false 180 180 90
Circle -16777216 true false 30 180 90
Polygon -16777216 true false 162 80 132 78 134 135 209 135 194 105 189 96 180 89
Circle -7500403 true true 47 195 58
Circle -7500403 true true 195 195 58

circle
false
0
Circle -7500403 true true 0 0 300

circle 2
false
0
Circle -7500403 true true 0 0 300
Circle -16777216 true false 30 30 240

cow
false
0
Polygon -7500403 true true 200 193 197 249 179 249 177 196 166 187 140 189 93 191 78 179 72 211 49 209 48 181 37 149 25 120 25 89 45 72 103 84 179 75 198 76 252 64 272 81 293 103 285 121 255 121 242 118 224 167
Polygon -7500403 true true 73 210 86 251 62 249 48 208
Polygon -7500403 true true 25 114 16 195 9 204 23 213 25 200 39 123

cylinder
false
0
Circle -7500403 true true 0 0 300

dot
false
0
Circle -7500403 true true 90 90 120

face happy
false
0
Circle -7500403 true true 8 8 285
Circle -16777216 true false 60 75 60
Circle -16777216 true false 180 75 60
Polygon -16777216 true false 150 255 90 239 62 213 47 191 67 179 90 203 109 218 150 225 192 218 210 203 227 181 251 194 236 217 212 240

face neutral
false
0
Circle -7500403 true true 8 7 285
Circle -16777216 true false 60 75 60
Circle -16777216 true false 180 75 60
Rectangle -16777216 true false 60 195 240 225

face sad
false
0
Circle -7500403 true true 8 8 285
Circle -16777216 true false 60 75 60
Circle -16777216 true false 180 75 60
Polygon -16777216 true false 150 168 90 184 62 210 47 232 67 244 90 220 109 205 150 198 192 205 210 220 227 242 251 229 236 206 212 183

fish
true
0
Polygon -1 true false 44 131 21 87 15 86 0 120 15 150 0 180 13 214 20 212 45 166
Polygon -1 true false 135 195 119 235 95 218 76 210 46 204 60 165
Polygon -1 true false 75 45 83 77 71 103 86 114 166 78 135 60
Polygon -7500403 true true 30 136 151 77 226 81 280 119 292 146 292 160 287 170 270 195 195 210 151 212 30 166
Circle -16777216 true false 215 106 30

flag
false
0
Rectangle -7500403 true true 60 15 75 300
Polygon -7500403 true true 90 150 270 90 90 30
Line -7500403 true 75 135 90 135
Line -7500403 true 75 45 90 45

flower
false
0
Polygon -10899396 true false 135 120 165 165 180 210 180 240 150 300 165 300 195 240 195 195 165 135
Circle -7500403 true true 85 132 38
Circle -7500403 true true 130 147 38
Circle -7500403 true true 192 85 38
Circle -7500403 true true 85 40 38
Circle -7500403 true true 177 40 38
Circle -7500403 true true 177 132 38
Circle -7500403 true true 70 85 38
Circle -7500403 true true 130 25 38
Circle -7500403 true true 96 51 108
Circle -16777216 true false 113 68 74
Polygon -10899396 true false 189 233 219 188 249 173 279 188 234 218
Polygon -10899396 true false 180 255 150 210 105 210 75 240 135 240

house
false
0
Rectangle -7500403 true true 45 120 255 285
Rectangle -16777216 true false 120 210 180 285
Polygon -7500403 true true 15 120 150 15 285 120
Line -16777216 false 30 120 270 120

leaf
false
0
Polygon -7500403 true true 150 210 135 195 120 210 60 210 30 195 60 180 60 165 15 135 30 120 15 105 40 104 45 90 60 90 90 105 105 120 120 120 105 60 120 60 135 30 150 15 165 30 180 60 195 60 180 120 195 120 210 105 240 90 255 90 263 104 285 105 270 120 285 135 240 165 240 180 270 195 240 210 180 210 165 195
Polygon -7500403 true true 135 195 135 240 120 255 105 255 105 285 135 285 165 240 165 195

line
true
0
Line -7500403 true 150 0 150 300

line half
true
0
Line -7500403 true 150 0 150 150

pentagon
false
0
Polygon -7500403 true true 150 15 15 120 60 285 240 285 285 120

person
false
0
Circle -7500403 true true 110 5 80
Polygon -7500403 true true 105 90 120 195 90 285 105 300 135 300 150 225 165 300 195 300 210 285 180 195 195 90
Rectangle -7500403 true true 127 79 172 94
Polygon -7500403 true true 195 90 240 150 225 180 165 105
Polygon -7500403 true true 105 90 60 150 75 180 135 105

plant
false
0
Rectangle -7500403 true true 135 90 165 300
Polygon -7500403 true true 135 255 90 210 45 195 75 255 135 285
Polygon -7500403 true true 165 255 210 210 255 195 225 255 165 285
Polygon -7500403 true true 135 180 90 135 45 120 75 180 135 210
Polygon -7500403 true true 165 180 165 210 225 180 255 120 210 135
Polygon -7500403 true true 135 105 90 60 45 45 75 105 135 135
Polygon -7500403 true true 165 105 165 135 225 105 255 45 210 60
Polygon -7500403 true true 135 90 120 45 150 15 180 45 165 90

sheep
false
15
Circle -1 true true 203 65 88
Circle -1 true true 70 65 162
Circle -1 true true 150 105 120
Polygon -7500403 true false 218 120 240 165 255 165 278 120
Circle -7500403 true false 214 72 67
Rectangle -1 true true 164 223 179 298
Polygon -1 true true 45 285 30 285 30 240 15 195 45 210
Circle -1 true true 3 83 150
Rectangle -1 true true 65 221 80 296
Polygon -1 true true 195 285 210 285 210 240 240 210 195 210
Polygon -7500403 true false 276 85 285 105 302 99 294 83
Polygon -7500403 true false 219 85 210 105 193 99 201 83

square
false
0
Rectangle -7500403 true true 30 30 270 270

square 2
false
0
Rectangle -7500403 true true 30 30 270 270
Rectangle -16777216 true false 60 60 240 240

star
false
0
Polygon -7500403 true true 151 1 185 108 298 108 207 175 242 282 151 216 59 282 94 175 3 108 116 108

target
false
0
Circle -7500403 true true 0 0 300
Circle -16777216 true false 30 30 240
Circle -7500403 true true 60 60 180
Circle -16777216 true false 90 90 120
Circle -7500403 true true 120 120 60

tree
false
0
Circle -7500403 true true 118 3 94
Rectangle -6459832 true false 120 195 180 300
Circle -7500403 true true 65 21 108
Circle -7500403 true true 116 41 127
Circle -7500403 true true 45 90 120
Circle -7500403 true true 104 74 152

triangle
false
0
Polygon -7500403 true true 150 30 15 255 285 255

triangle 2
false
0
Polygon -7500403 true true 150 30 15 255 285 255
Polygon -16777216 true false 151 99 225 223 75 224

truck
false
0
Rectangle -7500403 true true 4 45 195 187
Polygon -7500403 true true 296 193 296 150 259 134 244 104 208 104 207 194
Rectangle -1 true false 195 60 195 105
Polygon -16777216 true false 238 112 252 141 219 141 218 112
Circle -16777216 true false 234 174 42
Rectangle -7500403 true true 181 185 214 194
Circle -16777216 true false 144 174 42
Circle -16777216 true false 24 174 42
Circle -7500403 false true 24 174 42
Circle -7500403 false true 144 174 42
Circle -7500403 false true 234 174 42

turtle
true
0
Polygon -10899396 true false 215 204 240 233 246 254 228 266 215 252 193 210
Polygon -10899396 true false 195 90 225 75 245 75 260 89 269 108 261 124 240 105 225 105 210 105
Polygon -10899396 true false 105 90 75 75 55 75 40 89 31 108 39 124 60 105 75 105 90 105
Polygon -10899396 true false 132 85 134 64 107 51 108 17 150 2 192 18 192 52 169 65 172 87
Polygon -10899396 true false 85 204 60 233 54 254 72 266 85 252 107 210
Polygon -7500403 true true 119 75 179 75 209 101 224 135 220 225 175 261 128 261 81 224 74 135 88 99

wheel
false
0
Circle -7500403 true true 3 3 294
Circle -16777216 true false 30 30 240
Line -7500403 true 150 285 150 15
Line -7500403 true 15 150 285 150
Circle -7500403 true true 120 120 60
Line -7500403 true 216 40 79 269
Line -7500403 true 40 84 269 221
Line -7500403 true 40 216 269 79
Line -7500403 true 84 40 221 269

wolf
false
0
Polygon -16777216 true false 253 133 245 131 245 133
Polygon -7500403 true true 2 194 13 197 30 191 38 193 38 205 20 226 20 257 27 265 38 266 40 260 31 253 31 230 60 206 68 198 75 209 66 228 65 243 82 261 84 268 100 267 103 261 77 239 79 231 100 207 98 196 119 201 143 202 160 195 166 210 172 213 173 238 167 251 160 248 154 265 169 264 178 247 186 240 198 260 200 271 217 271 219 262 207 258 195 230 192 198 210 184 227 164 242 144 259 145 284 151 277 141 293 140 299 134 297 127 273 119 270 105
Polygon -7500403 true true -1 195 14 180 36 166 40 153 53 140 82 131 134 133 159 126 188 115 227 108 236 102 238 98 268 86 269 92 281 87 269 103 269 113

x
false
0
Polygon -7500403 true true 270 75 225 30 30 225 75 270
Polygon -7500403 true true 30 75 75 30 270 225 225 270
@#$#@#$#@
NetLogo 6.1.0
@#$#@#$#@
@#$#@#$#@
@#$#@#$#@
@#$#@#$#@
@#$#@#$#@
default
0.0
-0.2 0 0.0 1.0
0.0 1 1.0 0.0
0.2 0 0.0 1.0
link direction
true
0
Line -7500403 true 150 150 90 180
Line -7500403 true 150 150 210 180
@#$#@#$#@
0
@#$#@#$#@