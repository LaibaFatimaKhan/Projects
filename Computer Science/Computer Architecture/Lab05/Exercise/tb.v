module tb
(
);

reg [63:0] a;
reg [63:0] b;
reg CarryIn;
reg[3:0] ALUop;
wire [63:0] Result;
wire ZERO;

ALU_64_bit alu
(	
	.a(a),
	.b(b),
	.ALUop(ALUop),
	.Result(Result),
	.ZERO(ZERO)
);
	
	initial 
	begin
	a = 64'd6000;
	b = 64'd4;
	
	
	ALUop = 4'b0000; //And
	#100 ALUop = 4'b0001; //OR
	#100 ALUop = 4'b0010; //Add
	#100 ALUop = 4'b0110; //Subtract
	#100 ALUop = 4'b1100; //NOR
	
	
	
	
	
	
	end
	
	initial
	$monitor ("Time = ", $time, "  Operation = ", ALUop, " --------> Result = %d", Result, "  ZERO = %d", ZERO);
endmodule
