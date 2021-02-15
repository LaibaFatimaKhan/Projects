module tb
(

);

	reg [63:0] a;
	reg [63:0] b;
	reg sel;
	wire[63:0] q; 
	
	multiplexer mux
	(	
		.a(a),
		.b(b),
		.sel(sel),
		.data_out(q)

	);
	
	initial 
	begin
		a = 64'd49;
		b = 64'd92;
		sel = 1'b0;
		#20
		sel = 1'b1;
		#20
		a = 64'd1;
	end
	
	initial
	$monitor ("Time = ", $time, "  a= ", a, "  b= ", b, "  select= ", sel,  " --------> DataOut= %d", data_out);
	
endmodule
