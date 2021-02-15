;; text, like this, that start with semi-colons are comments and do not effect anything
;;
;; First we have lists of general and individual properties/slots

globals []

;; only attribute is color grey is suseptible, red infected and violet recovering
turtles-own []


;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;; Next we have the procedure to initialise the simulation
;; this is executed when one presses the "setup" button

to setup
  clear-all ;; this clears everything at the start - a clean slate

  create-turtles population [
    set shape "circle"
    set color grey
    ;;    sets position of nodes randomly
    setxy random-xcor random-ycor
  ]

  ;; link up network
  ask turtles [
    ;; each node links to a random selection of other nodes
    create-links-with n-of number-links-each other turtles
  ]


  repeat 100 [ layout-spring turtles links 0.2 5 2]
  reset-ticks            ;; this initialises the simulation time system and graphs
end

to infect-one-new
  ask one-of turtles [set color red]
end

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;; Next we have the procedure to progress the simulation one time step
;; this is executed when one presses the "step" button or repeatedly
;; if one presses the "go" button

to go
  ;; things that happen to susceptible
  ask turtles with [color = grey] [
    if any? link-neighbors with [color = red] [
      if with-probability prob-infect [
        set color red
      ]
    ]
  ]

  ;; things that happen to infected
  ask turtles with [color = red] [
    if with-probability prob-recover [
      set color violet
    ]
  ]

  ask turtles with [color = violet] [
    if with-probability prob-susceptible [
      set color grey
    ]
  ]

  tick                                   ;; this progresses the tick counter by one
end

;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;;
;; Finally we have definitions of the various action words/commands we use in the above
;; this makes the code easier to read and so that chunks of code can be reused at will
;; DO NOT WORRY about the detail of these (yet)

to-report with-probability [prob]
  ;; returns value "TRUE" with probability determined by input
  report random-float 1 < prob
end
@#$#@#$#@
GRAPHICS-WINDOW
210
10
648
449
-1
-1
10.5
1
10
1
1
1
0
0
0
1
0
40
0
40
0
0
1
ticks
30.0

BUTTON
105
47
168
80
NIL
go
T
1
T
OBSERVER
NIL
NIL
NIL
NIL
1

BUTTON
34
10
101
43
NIL
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

BUTTON
39
47
102
80
step
go
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
18
98
190
131
population
population
0
100
100.0
1
1
NIL
HORIZONTAL

SLIDER
19
136
192
169
number-links-each
number-links-each
0
10
2.0
1
1
NIL
HORIZONTAL

SLIDER
19
190
191
223
prob-infect
prob-infect
0
0.1
0.02
0.001
1
NIL
HORIZONTAL

BUTTON
106
11
172
44
infect
infect-one-new
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
19
228
191
261
prob-recover
prob-recover
0
0.1
0.015
0.001
1
NIL
HORIZONTAL

SLIDER
18
266
190
299
prob-susceptible
prob-susceptible
0
0.1
0.015
0.001
1
NIL
HORIZONTAL

PLOT
4
308
204
458
States
Time
Number
0.0
10.0
0.0
10.0
true
false
"" ""
PENS
"infected" 1.0 0 -2674135 true "" "plot count turtles with [color = red]"
"susceptible" 1.0 0 -7500403 true "" "plot count turtles with [color = grey]"
"pen-2" 1.0 0 -8630108 true "" "plot count turtles with [color = violet]"

@#$#@#$#@
## WHAT IS IT?

This is an example model, used as part of the "2-day Introduction to Agent-Based Modelling".  

It is a simple illustration of using a network in a model, with an infection caused which then spreads through the nodes.

## HOW IT WORKS

Select the paramters you want, including the network type (random or nearest).  

Press the infect button to infect a node.  

With each subsequent step there is a probability each grey that is linked to an infected node will get infected, but also a probability that any infected node will recover with immunity and a third probability that any immune node will become susceptible again.

## HOW TO USE IT

Press...
"setup" to initialise the simulation, namely the network of nodes
"infect" to infect a random node (necessary if anything is going to happen)
"step" to do a simulation step where nodes may be infected, recover and become suseptible to infection agoing
"go" to repeatedly do simulation steps - note that if all nodes become grey the simulation carries on doing noithing much fo 100,000 of simulation ticks!


## THINGS TO NOTICE/TRY

The settings of the three probabilities for infection, recovery or (re)suseptibility are crucial if there are going to be any long-term, sustained dynamics.  It can quickly revert to all-infected or all-susceptible states and stay there.  See if you can find such settings.

## EXTENDING THE MODEL

1. use a command such as "repeat 100 [ layout-spring turtles links 0.2 5 2]" to improve the layout of the network
1. add a plot to show the number of each colour of node (i.e. the number in each state)
1. change the code so some random links are added at the start using “ask” “one-of” and “create-links-with”
1. using the command “ask one-of my-links [die]” see if you can alter the code so that a node drops links if it is infected


## NETLOGO FEATURES

Note the use of the NetLogo network features.  There are a lot of netlogo primitives that can be used to create and manipulate networks, but you can create and use networks with only a few.

## CREDITS AND REFERENCES

Original SIR model was described in:

Kermack WO, McKendrick AG (August 1, 1927). "A Contribution to the Mathematical Theory of Epidemics". Proc. R. Soc. Lond. A 115 (772): 700–721. doi:10.1098/rspa.1927.0118.


Reseasonably accessible introduction to such models:

From the book Networks, Crowds, and Markets: Reasoning about a Highly Connected World.
By David Easley and Jon Kleinberg. Cambridge University Press, 2010.
Complete preprint on-line at http://www.cs.cornell.edu/home/kleinber/networks-book/

A review of such models and their behaviours:

Matt J Keeling1 and Ken T.D Eames (2005) Networks and epidemic models J. R. Soc. Interface 22 September 2005 vol. 2 no. 4 295-307 
http://rsif.royalsocietypublishing.org/content/2/4/295.full

A slightly more sophisticated online NetLogo version of the model: http://ccl.northwestern.edu/netlogo/models/VirusonaNetwork


Model by Bruce Edmonds, Feb 2013
http://cfpm.org/simulationcourse
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
false
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
0
Rectangle -7500403 true true 151 225 180 285
Rectangle -7500403 true true 47 225 75 285
Rectangle -7500403 true true 15 75 210 225
Circle -7500403 true true 135 75 150
Circle -16777216 true false 165 76 116

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
Polygon -7500403 true true 135 285 195 285 270 90 30 90 105 285
Polygon -7500403 true true 270 90 225 15 180 90
Polygon -7500403 true true 30 90 75 15 120 90
Circle -1 true false 183 138 24
Circle -1 true false 93 138 24

x
false
0
Polygon -7500403 true true 270 75 225 30 30 225 75 270
Polygon -7500403 true true 30 75 75 30 270 225 225 270
@#$#@#$#@
NetLogo 6.1.1
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
