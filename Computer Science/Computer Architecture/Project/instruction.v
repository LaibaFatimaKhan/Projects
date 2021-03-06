module instruction
(
	input [31:0] instruction,

	output reg [6:0] opcode, funct7, [4:0] rd, rs1, rs2, [2:0] funct3
);
	always @(instruction)
	begin
		opcode = instruction[6:0];
		rd = instruction[11:7];
		funct3 = instruction[14:12];
		rs1 = instruction[19:15];
		rs2 = instruction[24:20];
		funct7 = instruction[31:25];
	end
	
endmodule
