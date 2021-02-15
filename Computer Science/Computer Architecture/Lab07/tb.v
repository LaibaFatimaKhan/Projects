module tb
(

);

	reg [63:0]WriteData;
	reg [4:0]RS1;
	reg [4:0]RS2;
	reg [4:0]RD;
	reg RegWrite, clk, reset;
	wire  [63:0]ReadData1;
	wire  [63:0]ReadData2;
	
	registerFile regFile
	(	
		.WriteData(WriteData),
		.RS1(RS1),
		.RS2(RS2),
		.RD(RD),
		.RegWrite(RegWrite),
		.clk(clk),
		.reset(reset),
		.ReadData1(ReadData1),
		.ReadData2(ReadData2)
	);
	
	initial
	begin	
		clk = 1;
		RegWrite = 0;
		reset = 1;
		
		#100
		reset = 0; 
		RS1 = 10; //ReadData1 reads register 11
		RS2 = 15; //ReadData2 reads register 16
		WriteData = 31;
		RD = 20;  //register 21 set as RD to write 31
		
		#100 RegWrite = 1;//allow write in register 21


		#300
		RS1 = 20;  //ReadData1 reads from register 21 
		            //which now has value 31
		
	end
	
	//$monitor ("Time = ", $time, " RegWrite= ", RegWrite, " reset= ", reset," --------> ReadData1= %d", ReadData1);
	
endmodule
	