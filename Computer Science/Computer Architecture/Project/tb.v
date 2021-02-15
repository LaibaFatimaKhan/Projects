module tb
(
);
reg clk;
reg reset;

RISC_V_Processor riscv
(
	.clk(clk),
	.reset(reset)
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