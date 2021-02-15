
module immediate_data_extractor
(
	input [31:0] instruction,

	output reg [63:0] imm_data
);
	always @(instruction)
	begin
		case(instruction[6:5])
		
			2'b00 : imm_data <= {{52{instruction[31]}},instruction[31:20]}; //I type Load
			2'b01 : imm_data <= {{52{instruction[31]}}, instruction[31:25], instruction[11:7]}; //S type Store
			2'b11 : imm_data <= {{51{instruction[31]}},instruction[31],instruction[7],instruction[30:25],instruction[11:8],1'b0};//R type (Conditional branch works with sub)
		endcase
	end
	
endmodule
