module ALU_6_bit
(
	input [5:0] a, 
	input [5:0] b,
	input CarryIn,
	input[3:0] ALUop,
	output [5:0] Result, 
	output CarryOut
);

wire [4:0] carr;
ALU_1_bit alu0
(
.a(a[0]),
.b(b[0]),
.CarryIn(CarryIn),
.ALUop(ALUop),
.Result(Result[0]),
.CarryOut(carr[0])
);

ALU_1_bit alu1
(
.a(a[1]),
.b(b[1]),
.CarryIn(carr[0]),
.ALUop(ALUop),
.Result(Result[1]),
.CarryOut(carr[1])
);

ALU_1_bit alu2
(
.a(a[2]),
.b(b[2]),
.CarryIn(carr[1]),
.ALUop(ALUop),
.Result(Result[2]),
.CarryOut(carr[2])
);

ALU_1_bit alu3
(
.a(a[3]),
.b(b[3]),
.CarryIn(carr[2]),
.ALUop(ALUop),
.Result(Result[3]),
.CarryOut(carr[3])
);

ALU_1_bit alu4
(
.a(a[4]),
.b(b[4]),
.CarryIn(carr[3]),
.ALUop(ALUop),
.Result(Result[4]),
.CarryOut(carr[4])
);

ALU_1_bit alu5
(
.a(a[5]),
.b(b[5]),
.CarryIn(carr[4]),
.ALUop(ALUop),
.Result(Result[5]),
.CarryOut(CarryOut)
);

endmodule