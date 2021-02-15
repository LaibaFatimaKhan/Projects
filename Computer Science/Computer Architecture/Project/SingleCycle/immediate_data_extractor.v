
module immediate_data_extractor
(
	input [31:0] instruction,

	output reg [63:0] imm_data
);
	always @(instruction)
	begin
		case(instruction[6])
			1'b1: imm_data <= {{52{instruction[31]}},instruction[31],instruction[7],instruction[30:25],instruction[11:8]};//R type (Conditional branch works with sub)
			1'b0:
			begin
				case(instruction[5])
					1'b0 : imm_data <= {{52{instruction[31]}},instruction[31:20]}; //I type Load
					1'b1 : imm_data <= {{52{instruction[31]}}, instruction[31:25], instruction[11:7]}; //S type Store
				endcase
			end
		endcase
	end 
	
endmodule
