module tb
(
);
	reg[63:0] Mem_Addr, Write_Data;
	reg clk, Mem_Write, Mem_Read;
	wire[63:0] Read_Data;
	
	Data_Memory data_memory
	(
		.Mem_Addr(Mem_Addr),
		.Write_Data(Write_Data),
		.clk(clk),
		.Mem_Write(Mem_Write),
		.Mem_Read(Mem_Read),
		.Read_Data(Read_Data)
	);
	
	initial
	begin
	clk = 0;
	Write_Data = 64'd10;
	Mem_Addr = 64'd0;
	Mem_Write = 1;
	Mem_Read = 1;
	
	#100
	Mem_Addr = 64'd8;
	Mem_Read = 0;
	
	#100
	Write_Data = 64'd4;
	
	#50
	Mem_Read = 1;
	end
	
	always
	#50 clk = ~clk;

	 
	endmodule
