#compiling task1 modules
vlog tb.v ALU_64_bit.v

#no optimization
vsim -novopt work.tb

#view waves
view wave

#adding waves

add wave sim:/tb/a
add wave sim:/tb/b
add wave sim:/tb/Result
add wave sim:/tb/ZERO

run 500ns