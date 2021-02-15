#compiling design modules 
vlog Adder.v ALU_64_bit.v ALU_Control.v Control_Unit.v Data_Memory.v immediate_data_extractor.v instruction.v Instruction_Memory.v multiplexer.v Program_Counter.v registerFile.v RISCV.v tb.v

#no optimization
vsim -novopt work.tb

#view waves
view wave

#adding waves

add wave sim:/tb/clk
add wave sim:/tb/reset
add wave sim:/tb/riscv/DataMemory_Read_Data
add wave sim:/tb/riscv/Instruction_Out_wire
add wave sim:/riscv/PC_Out_wire
run 1000ns