module tb
(

);

	reg[31:0] instruction;
	
	wire[63:0] ReadData1;
	wire[63:0] ReadData2;
	
	top tp
	(	
		.instruction(instruction),
		.ReadData1(ReadData1),
		.ReadData2(ReadData2)
	);
	
	initial
	begin	
	instruction = 32'b00000000001000001000001010110011; //add x5, x1, x2

	end

endmodule
