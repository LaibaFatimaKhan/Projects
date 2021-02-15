module Instruction_Memory
(
	input[63:0] Inst_Address,
	output reg[31:0] Instruction 

);
	reg[7:0] Inst_Mem[15:0];


	//initialize acc to fig:8.3
	initial 
		begin
			Inst_Mem[0] = 8'b10000011;
			Inst_Mem[1] = 8'b00110100;
			Inst_Mem[2] = 8'b10000101;
			Inst_Mem[3] = 8'b00000010;
			Inst_Mem[4] = 8'b10110011;
			Inst_Mem[5] = 8'b10000100;
			Inst_Mem[6] = 8'b10011010;
			Inst_Mem[7] = 8'b00000000;
			Inst_Mem[8] = 8'b10010011;
			Inst_Mem[9] = 8'b10000100;
			Inst_Mem[10] = 8'b00010100;
			Inst_Mem[11] = 8'b00000000;
			Inst_Mem[12] = 8'b00100011;
			Inst_Mem[13] = 8'b00110100;
			Inst_Mem[14] = 8'b10010101; 
			Inst_Mem[15] = 8'b00000010; 
		end
		
	always@(*)
	begin
		//concatenate Inst_Mem[Inst_Address+3:Inst_Address] as output Instruction
		assign Instruction = { Inst_Mem[Inst_Address+3], Inst_Mem[Inst_Address+2] ,Inst_Mem[Inst_Address+1], Inst_Mem[Inst_Address]};
	end

endmodule
