module tb
(
);

reg a, b, CarryIn;
reg[3:0] ALUop;
wire Result;
wire CarryOut;

ALU_1_bit alu
(	
	.a(a),
	.b(b),
	.CarryIn(CarryIn),
	.ALUop(ALUop),
	.Result(Result),
	.CarryOut(CarryOut)
);
	
	initial 
	begin
	a = 1'b1;
	b = 1'b1;
	CarryIn = 1'b0;
	
	ALUop = 4'b0000; //And
	#100 ALUop = 4'b0001; //OR
	#100 ALUop = 4'b0010; //Add
	#100 ALUop = 4'b1100; //NOR
	
	#100 ALUop = 4'b0110; //Subtract
	CarryIn = 1'b1;
	
	end
	
	
	initial
	$monitor ("Time = ", $time, "  Operation = ", ALUop, " --------> Result = %d", Result, "  Carry Out = %d", CarryOut);
endmodule
