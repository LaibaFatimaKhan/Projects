module ALU_64_bit
(
	input [63:0]a, 
	input [63:0]b, 
	
	input[3:0] ALUop,
	output [63:0]Result, 
	output ZERO
);

	
	reg [63:0]regRes;
	assign Result = regRes;
	
	reg zer;
	assign ZERO = zer;
	
	
//* so always block runs in all conditions
	always@(*)
	begin
		case(ALUop[3:0]) //Operation is last two bits of ALUop
			4'd0: regRes = (a & b);   //AND when Operation is 0
			4'd1: regRes = (a | b);   //OR  when Operation is 1
			4'd2: regRes = (a + b);	//add when Operation is 2
			4'd6: regRes = (a - b);
			4'd12: regRes = ~(a | b);
		endcase
		
		case(regRes)
		64'd0: zer = 1;
		default: zer = 0;
		endcase
	end 
endmodule