module tb
(

);

	reg [31:0] instruction;

	wire[6:0] opcode, funct7; 
	wire[4:0] rd, rs1, rs2;
	wire[2:0] funct3;
	
	instruction ins
	(	
		.instruction(instruction),
		.opcode(opcode),
		.funct7(funct7),
		.rd(rd),
		.rs1(rs1),
		.rs2(rs2),
		.funct3(funct3)

	);
	
	initial 
	instruction = 32'b00000000100001001000010100110011; //add with rs2:16 rs1:17 rd:18
	
	

endmodule
