
module ALU_1_bit
(
	input a, b, CarryIn,
	input[3:0] ALUop,
	output Result, CarryOut
);

	wire abar, bbar, mux1out, mux2out;
	
	assign abar = ~a;
	assign bbar = ~b;
	
	assign mux1out = ALUop[3] ? abar : a;   //Ainvert is ALUop bit 3 
	assign mux2out = ALUop[2] ? bbar : b;   //Binvert is ALUop bit 2
	
	reg regRes;
	assign Result = regRes;
	reg car;
	assign CarryOut = car;
	
//* so always block runs in all conditions
	always@(*)
	begin
		case(ALUop[1:0]) //Operation is last two bits of ALUop
			2'd0: regRes = (mux1out & mux2out);   //AND when Operation is 0
			2'd1: regRes = (mux1out | mux2out);   //OR  when Operation is 1
			2'd2: regRes = (mux1out + mux2out + CarryIn);	//add when Operation is 2
		endcase
		
		car = mux1out & CarryIn | mux2out & CarryIn | mux1out & mux2out;  //Formula to calculate CarryOut
	end 
endmodule


