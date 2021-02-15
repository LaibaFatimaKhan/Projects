module Instruction_Fetch
(
	input clk, reset,
	output[31:0] Instruction
);

	wire[63:0] pc_wire;
	wire[63:0] add_out;
	
	Program_Counter PC
	(
		.clk(clk),
		.reset(reset),
		.PC_In(add_out),
		.PC_Out(pc_wire)
	);
	
	Instruction_Memory ins_mem
	(
		.Inst_Address(pc_wire),
		.Instruction(Instruction)
	);
	
	Adder adder
	(
		.a(pc_wire),
		.b(64'd4),
		.out(add_out)
	
	);


endmodule
