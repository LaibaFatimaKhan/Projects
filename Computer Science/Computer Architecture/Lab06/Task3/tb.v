module tb
(

);

	reg [31:0] instruction;

	wire[63:0] imm_data;
	
	immediate_data_extractor dExt
	(	
		.instruction(instruction),
		.imm_data(imm_data)
	);
	
	initial
	begin	
	instruction = 32'b00001111000001010011010010000011; 
	end

endmodule
