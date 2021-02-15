module  RISC_V_Processor
(
	input clk, reset
);

    wire[63:0] PC_In_wire;
	wire[63:0] PC_Out_wire;	
	wire[31:0] Instruction_Out_wire; 
	wire [63:0] Adder1_Out_Wire;
	wire [63:0] Adder2_Out_Wire;
	wire [3:0] Operation_Wire;
	wire [63:0] MUX_Data_Out_Wire;
	wire [63:0] ALU_Result_Wire;
	wire [63:0] Immediate_Data_Wire;
	wire [6:0] opcode_wire, funct7_wire;
	wire [4:0] rd_wire, rs1_wire, rs2_wire;
	wire [2:0] funct3_wire;
	wire [63:0]ReadData1_wire, ReadData2_wire;
	wire Zero_Wire;
	wire [63:0] Register_WriteData_Wire;
	wire [63:0] DataMemory_Read_Data;
	
	wire Branch_wire, MemRead_wire, MemtoReg_wire, MemWrite_wire, ALUSrc_wire, RegWrite_wire;
	wire [1:0]ALUOp_wire;

Program_Counter PC
(
	.clk(clk),
	.reset(reset),
	.PC_In(PC_In_wire),
	.PC_Out(PC_Out_wire)		
);

Adder Adder1
(
	.a(PC_Out_wire),
	.b(64'd4),
	.out(Adder1_Out_Wire)
	
);
	
Adder Adder2
(
	.a(PC_Out_wire),
	.b(Immediate_Data_Wire<<1),
	.out(Adder2_Out_Wire)
);
multiplexer Mux1
(
	.sel(Zero_Wire & Branch_wire),
	.b(Adder1_Out_Wire),
	.a(Adder2_Out_Wire),
	.data_out(PC_In_wire)
);
	
multiplexer Mux2
(
	.sel(ALUSrc_wire),
	.b(ReadData2_wire),
	.a(Immediate_Data_Wire),
	.data_out(MUX_Data_Out_Wire)
);
	
multiplexer Mux3
(
	.sel(MemtoReg_wire),
	.b(ALU_Result_Wire),
	.a(DataMemory_Read_Data),
	.data_out(Register_WriteData_Wire)
);

Instruction_Memory InsMem
(
	.Inst_Address(PC_Out_wire),
	.Instruction(Instruction_Out_wire) 
);	
	
instruction Ins
(
	.instruction(Instruction_Out_wire),
	.rs1(rs1_wire),
	.rs2(rs2_wire),
	.rd(rd_wire),
	.funct3(funct3_wire),
	.funct7(funct7_wire),
	.opcode(opcode_wire)
);
	
Control_Unit CtrlUnit
(
	.Opcode(opcode_wire),
	.Branch(Branch_wire),
	.MemRead(MemRead_wire), 
	.MemtoReg(MemtoReg_wire), 
	.MemWrite(MemWrite_wire), 
	.ALUSrc(ALUSrc_wire), 
	.RegWrite(RegWrite_wire),
	.ALUOp(ALUOp_wire)
);

registerFile RegFile
(
	.RS1(rs1_wire),
	.RS2(rs2_wire),
	.RD(rd_wire),
	.ReadData1(ReadData1_wire),
	.ReadData2(ReadData2_wire),
	.WriteData(Register_WriteData_Wire),
	.RegWrite(RegWrite_wire),
	.clk(clk),
	.reset(reset)
);

dataExtractor DataExtract
(
	.instruction(Instruction_Out_wire),
	.imm_data(Immediate_Data_Wire)
);
	
ALU_Control ALUCtrl
(
	.ALUOp(ALUOp_wire),
	.Funct({Instruction_Out_wire[30], Instruction_Out_wire[14:12]}),
	.Operation(Operation_Wire)
);
	
ALU_64_bit ALU
(
	.a(ReadData1_wire),
	.b(MUX_Data_Out_Wire),
	.ALUOp(Operation_Wire),
	.Result(ALU_Result_Wire),
	.ZERO(Zero_Wire)
);
Data_Memory DataMem
(
	.Mem_Addr(ALU_Result_Wire),
	.Write_Data(ReadData2_wire),
	.clk(clk),
	.Mem_Write(MemWrite_wire),
	.Mem_Read(MemRead_wire),
	.Read_Data(DataMemory_Read_Data)
);
endmodule
