module tb
(
);
	reg[63:0] Inst_Address;
	wire[31:0] Instruction; 
	
	Instruction_Memory instruction_memory
	(
		.Inst_Address(Inst_Address),
		.Instruction(Instruction)
	);
	
	initial
	begin
	Inst_Address = 64'd0;
	#400
	Inst_Address = 64'd4;
	
	end
		
endmodule
