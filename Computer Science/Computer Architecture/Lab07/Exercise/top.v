module top
(
	input [31:0]instruction,

	output  [63:0]ReadData1,
	output  [63:0]ReadData2
);
	wire[4:0] R1;
	wire[4:0] R2;
	wire[4:0] RDwire;


	instruction instr
	(
		.instruction(instruction),
		.opcode(),
		.funct7(),
		.rd(RDwire),
		.rs1(R1),
		.rs2(R2),
		.funct3()
	);
	
	
	registerFile regFi1e
	(
		.WriteData(100),
		.RegWrite(0),
		.clk(1),
		.reset(1),
		.RS1(R1-1),
		.RS2(R2-1),
		.RD(RDwire-1),
		.ReadData1(ReadData1),
		.ReadData2(ReadData2)
	);
	

endmodule
