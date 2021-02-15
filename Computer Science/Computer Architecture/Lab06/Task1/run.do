#compiling task1 modules
vlog tb.v multiplexer.v

#no optimization
vsim -novopt work.tb

#view waves
view wave

#adding waves

add wave sim:/tb/a
add wave sim:/tb/b
add wave sim:/tb/sel
add wave sim:/tb/data_out

run 500ns