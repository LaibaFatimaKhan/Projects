module Control_Unit
(
	input[6:0] Opcode,
	output reg Branch, MemRead, MemtoReg, MemWrite, ALUSrc, RegWrite,
	output reg[1:0] ALUOp
 
);

	always@(Opcode)
	begin
	case(Opcode)
		7'b0110011 :  //R-Type
		begin
		ALUSrc = 	0;
		MemtoReg =	0;
		RegWrite = 1;
		MemRead = 	0;
		MemWrite = 0;
		Branch =	0;
		ALUOp =	2'b10;
		end
		
		7'b0000011 : //I-Type (ld)
		begin
		ALUSrc <=	1;
		MemtoReg <=	1;
		RegWrite <= 1;
		MemRead <=	1;
		MemWrite <= 0;
		Branch <=	0;
		ALUOp <=	2'b00;
		end

		7'b0100011  : //I-Type (sd)
		begin
		ALUSrc <=	1;
		MemtoReg <=	1'bx;
		RegWrite <= 0;
		MemRead <=	0;
		MemWrite <= 1;
		Branch <=	0;
		ALUOp <=	2'b00;
		end

		7'b1100011  : //SB-Type (beq)
		begin
		ALUSrc <=	0;
		MemtoReg <=	1'bx;
		RegWrite <= 0;
		MemRead <=	0;
		MemWrite <= 0;
		Branch <=	1;
		ALUOp <=	2'b01;
		end
		
		7'b0010011  : //Addi
		begin
		ALUSrc <=	1;
		MemtoReg <=	1'b0;
		RegWrite <= 1;
		MemRead <=	1;
		MemWrite <= 0;
		Branch <=	0;
		ALUOp <=	2'b00;
		end
				
				
	endcase
	end

endmodule
