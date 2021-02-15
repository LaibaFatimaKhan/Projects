module Data_Memory
(
	input[63:0] Mem_Addr, Write_Data,
	input clk, Mem_Write, Mem_Read,
	output reg[63:0] Read_Data
);

	reg [7:0] DM [63:0];

	integer i;
	
	initial
	begin
	for (i=0; i<64; i=i+1)
	DM[i] = i;
	end
	
	always@(posedge clk)
	begin
		if (Mem_Write == 1)
		begin
			 DM[Mem_Addr] = Write_Data[7:0];
			 DM[Mem_Addr+1] = Write_Data[15:8];
			 DM[Mem_Addr+2] = Write_Data[23:16];
			 DM[Mem_Addr+3] = Write_Data[31:17];
			 DM[Mem_Addr+4] = Write_Data[39:18];
			 DM[Mem_Addr+5] = Write_Data[47:40];
			 DM[Mem_Addr+6] = Write_Data[55:48];
			 DM[Mem_Addr+7] = Write_Data[63:56];			
		end
	end
	
	always@(Mem_Addr or Mem_Read or DM)
	begin
		if (Mem_Read == 1)
		begin
		Read_Data = { DM[Mem_Addr+7], DM[Mem_Addr+6], DM[Mem_Addr+5], DM[Mem_Addr+4], DM[Mem_Addr+3], DM[Mem_Addr+2], DM[Mem_Addr+1], DM[Mem_Addr]   };
		end
	
	end


endmodule
