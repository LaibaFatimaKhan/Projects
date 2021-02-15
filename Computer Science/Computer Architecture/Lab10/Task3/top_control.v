module top_control
(
	input[6:0] Opcode,
	input[3:0] Funct, 
	output Branch, MemRead, MemtoReg, MemWrite, ALUSrc, RegWrite,
	output[3:0] Operation
);
	wire[1:0] ALUOp_wire;

	Control_Unit con
	(
		.Opcode(Opcode),
		.Branch(Branch),
		.MemRead(MemRead), 
		.MemtoReg(MemtoReg), 
		.MemWrite(MemWrite), 
		.ALUSrc(ALUSrc), 
		.RegWrite(RegWrite),
		.ALUOp(ALUOp_wire)
	 
	);
	ALU_Control alu_con
	(
		.ALUOp(ALUOp_wire),
		.Funct(Funct),
		.Operation(Operation)
	);
endmodule
