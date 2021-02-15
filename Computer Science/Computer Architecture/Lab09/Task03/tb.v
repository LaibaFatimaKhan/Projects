module tb
(
);
	reg clk, reset;
	wire [31:0] Instruction;
	
	Instruction_Fetch instruction_fetch
	(
		.clk(clk),
		.reset(reset),
		.Instruction(Instruction)
	);
	
	initial
	begin
	 clk = 0;
	 reset = 1;		
	 #10 reset = ~reset;
	end
	
	
	always 
	#5 clk = ~clk;
	
	
endmodule
