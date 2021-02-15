module tb
(
);
	reg[6:0] Opcode;
	reg[3:0] Funct; 
	wire Branch; 
	wire MemRead; 
	wire MemtoReg; 
	wire MemWrite; 
	wire ALUSrc; 
	wire RegWrite;
	wire[3:0] Operation;
	
	top_control top
	(
		.Opcode(Opcode),
		.Funct(Funct), 
		.Branch(Branch),
		.MemRead(MemRead), 
		.MemtoReg(MemtoReg), 
		.MemWrite(MemWrite), 
		.ALUSrc(ALUSrc), 
		.RegWrite(RegWrite),
		.Operation(Operation)
	);
	initial
	begin
	 Funct = 4'b1000;	
	 Opcode = 7'b0110011;  //R-Type
	#50 
	 Opcode = 7'b1100011;	//SB-Type
	#50
	 Opcode =  7'b0000011; //I-Type (ld)
	end
endmodule
