//---------------------------------------------------------------------
//  This file is part of the CLR Managed Debugger (mdbg) Sample.
// 
//  Copyright (C) Microsoft Corporation.  All rights reserved.
//---------------------------------------------------------------------
										
// generated file; DO NOT MODIFY                        
using System;											
namespace Microsoft.Samples.Tools.Mdbg.Extension				
{														
public enum ILOpCode 
{
CEE_NOP=0,
CEE_BREAK=1,
CEE_LDARG_0=2,
CEE_LDARG_1=3,
CEE_LDARG_2=4,
CEE_LDARG_3=5,
CEE_LDLOC_0=6,
CEE_LDLOC_1=7,
CEE_LDLOC_2=8,
CEE_LDLOC_3=9,
CEE_STLOC_0=10,
CEE_STLOC_1=11,
CEE_STLOC_2=12,
CEE_STLOC_3=13,
CEE_LDARG_S=14,
CEE_LDARGA_S=15,
CEE_STARG_S=16,
CEE_LDLOC_S=17,
CEE_LDLOCA_S=18,
CEE_STLOC_S=19,
CEE_LDNULL=20,
CEE_LDC_I4_M1=21,
CEE_LDC_I4_0=22,
CEE_LDC_I4_1=23,
CEE_LDC_I4_2=24,
CEE_LDC_I4_3=25,
CEE_LDC_I4_4=26,
CEE_LDC_I4_5=27,
CEE_LDC_I4_6=28,
CEE_LDC_I4_7=29,
CEE_LDC_I4_8=30,
CEE_LDC_I4_S=31,
CEE_LDC_I4=32,
CEE_LDC_I8=33,
CEE_LDC_R4=34,
CEE_LDC_R8=35,
CEE_UNUSED49=36,
CEE_DUP=37,
CEE_POP=38,
CEE_JMP=39,
CEE_CALL=40,
CEE_CALLI=41,
CEE_RET=42,
CEE_BR_S=43,
CEE_BRFALSE_S=44,
CEE_BRTRUE_S=45,
CEE_BEQ_S=46,
CEE_BGE_S=47,
CEE_BGT_S=48,
CEE_BLE_S=49,
CEE_BLT_S=50,
CEE_BNE_UN_S=51,
CEE_BGE_UN_S=52,
CEE_BGT_UN_S=53,
CEE_BLE_UN_S=54,
CEE_BLT_UN_S=55,
CEE_BR=56,
CEE_BRFALSE=57,
CEE_BRTRUE=58,
CEE_BEQ=59,
CEE_BGE=60,
CEE_BGT=61,
CEE_BLE=62,
CEE_BLT=63,
CEE_BNE_UN=64,
CEE_BGE_UN=65,
CEE_BGT_UN=66,
CEE_BLE_UN=67,
CEE_BLT_UN=68,
CEE_SWITCH=69,
CEE_LDIND_I1=70,
CEE_LDIND_U1=71,
CEE_LDIND_I2=72,
CEE_LDIND_U2=73,
CEE_LDIND_I4=74,
CEE_LDIND_U4=75,
CEE_LDIND_I8=76,
CEE_LDIND_I=77,
CEE_LDIND_R4=78,
CEE_LDIND_R8=79,
CEE_LDIND_REF=80,
CEE_STIND_REF=81,
CEE_STIND_I1=82,
CEE_STIND_I2=83,
CEE_STIND_I4=84,
CEE_STIND_I8=85,
CEE_STIND_R4=86,
CEE_STIND_R8=87,
CEE_ADD=88,
CEE_SUB=89,
CEE_MUL=90,
CEE_DIV=91,
CEE_DIV_UN=92,
CEE_REM=93,
CEE_REM_UN=94,
CEE_AND=95,
CEE_OR=96,
CEE_XOR=97,
CEE_SHL=98,
CEE_SHR=99,
CEE_SHR_UN=100,
CEE_NEG=101,
CEE_NOT=102,
CEE_CONV_I1=103,
CEE_CONV_I2=104,
CEE_CONV_I4=105,
CEE_CONV_I8=106,
CEE_CONV_R4=107,
CEE_CONV_R8=108,
CEE_CONV_U4=109,
CEE_CONV_U8=110,
CEE_CALLVIRT=111,
CEE_CPOBJ=112,
CEE_LDOBJ=113,
CEE_LDSTR=114,
CEE_NEWOBJ=115,
CEE_CASTCLASS=116,
CEE_ISINST=117,
CEE_CONV_R_UN=118,
CEE_UNUSED58=119,
CEE_UNUSED1=120,
CEE_UNBOX=121,
CEE_THROW=122,
CEE_LDFLD=123,
CEE_LDFLDA=124,
CEE_STFLD=125,
CEE_LDSFLD=126,
CEE_LDSFLDA=127,
CEE_STSFLD=128,
CEE_STOBJ=129,
CEE_CONV_OVF_I1_UN=130,
CEE_CONV_OVF_I2_UN=131,
CEE_CONV_OVF_I4_UN=132,
CEE_CONV_OVF_I8_UN=133,
CEE_CONV_OVF_U1_UN=134,
CEE_CONV_OVF_U2_UN=135,
CEE_CONV_OVF_U4_UN=136,
CEE_CONV_OVF_U8_UN=137,
CEE_CONV_OVF_I_UN=138,
CEE_CONV_OVF_U_UN=139,
CEE_BOX=140,
CEE_NEWARR=141,
CEE_LDLEN=142,
CEE_LDELEMA=143,
CEE_LDELEM_I1=144,
CEE_LDELEM_U1=145,
CEE_LDELEM_I2=146,
CEE_LDELEM_U2=147,
CEE_LDELEM_I4=148,
CEE_LDELEM_U4=149,
CEE_LDELEM_I8=150,
CEE_LDELEM_I=151,
CEE_LDELEM_R4=152,
CEE_LDELEM_R8=153,
CEE_LDELEM_REF=154,
CEE_STELEM_I=155,
CEE_STELEM_I1=156,
CEE_STELEM_I2=157,
CEE_STELEM_I4=158,
CEE_STELEM_I8=159,
CEE_STELEM_R4=160,
CEE_STELEM_R8=161,
CEE_STELEM_REF=162,
CEE_UNUSED2=163,
CEE_UNUSED3=164,
CEE_UNUSED4=165,
CEE_UNUSED5=166,
CEE_UNUSED6=167,
CEE_UNUSED7=168,
CEE_UNUSED8=169,
CEE_UNUSED9=170,
CEE_UNUSED10=171,
CEE_UNUSED11=172,
CEE_UNUSED12=173,
CEE_UNUSED13=174,
CEE_UNUSED14=175,
CEE_UNUSED15=176,
CEE_UNUSED16=177,
CEE_UNUSED17=178,
CEE_CONV_OVF_I1=179,
CEE_CONV_OVF_U1=180,
CEE_CONV_OVF_I2=181,
CEE_CONV_OVF_U2=182,
CEE_CONV_OVF_I4=183,
CEE_CONV_OVF_U4=184,
CEE_CONV_OVF_I8=185,
CEE_CONV_OVF_U8=186,
CEE_UNUSED50=187,
CEE_UNUSED18=188,
CEE_UNUSED19=189,
CEE_UNUSED20=190,
CEE_UNUSED21=191,
CEE_UNUSED22=192,
CEE_UNUSED23=193,
CEE_REFANYVAL=194,
CEE_CKFINITE=195,
CEE_UNUSED24=196,
CEE_UNUSED25=197,
CEE_MKREFANY=198,
CEE_UNUSED59=199,
CEE_UNUSED60=200,
CEE_UNUSED61=201,
CEE_UNUSED62=202,
CEE_UNUSED63=203,
CEE_UNUSED64=204,
CEE_UNUSED65=205,
CEE_UNUSED66=206,
CEE_UNUSED67=207,
CEE_LDTOKEN=208,
CEE_CONV_U2=209,
CEE_CONV_U1=210,
CEE_CONV_I=211,
CEE_CONV_OVF_I=212,
CEE_CONV_OVF_U=213,
CEE_ADD_OVF=214,
CEE_ADD_OVF_UN=215,
CEE_MUL_OVF=216,
CEE_MUL_OVF_UN=217,
CEE_SUB_OVF=218,
CEE_SUB_OVF_UN=219,
CEE_ENDFINALLY=220,
CEE_LEAVE=221,
CEE_LEAVE_S=222,
CEE_STIND_I=223,
CEE_CONV_U=224,
CEE_UNUSED26=225,
CEE_UNUSED27=226,
CEE_UNUSED28=227,
CEE_UNUSED29=228,
CEE_UNUSED30=229,
CEE_UNUSED31=230,
CEE_UNUSED32=231,
CEE_UNUSED33=232,
CEE_UNUSED34=233,
CEE_UNUSED35=234,
CEE_UNUSED36=235,
CEE_UNUSED37=236,
CEE_UNUSED38=237,
CEE_UNUSED39=238,
CEE_UNUSED40=239,
CEE_UNUSED41=240,
CEE_UNUSED42=241,
CEE_UNUSED43=242,
CEE_UNUSED44=243,
CEE_UNUSED45=244,
CEE_UNUSED46=245,
CEE_UNUSED47=246,
CEE_UNUSED48=247,
CEE_PREFIX7=248,
CEE_PREFIX6=249,
CEE_PREFIX5=250,
CEE_PREFIX4=251,
CEE_PREFIX3=252,
CEE_PREFIX2=253,
CEE_PREFIX1=254,
CEE_PREFIXREF=255,
CEE_ARGLIST=256,
CEE_CEQ=257,
CEE_CGT=258,
CEE_CGT_UN=259,
CEE_CLT=260,
CEE_CLT_UN=261,
CEE_LDFTN=262,
CEE_LDVIRTFTN=263,
CEE_UNUSED56=264,
CEE_LDARG=265,
CEE_LDARGA=266,
CEE_STARG=267,
CEE_LDLOC=268,
CEE_LDLOCA=269,
CEE_STLOC=270,
CEE_LOCALLOC=271,
CEE_UNUSED57=272,
CEE_ENDFILTER=273,
CEE_UNALIGNED=274,
CEE_VOLATILE=275,
CEE_TAILCALL=276,
CEE_INITOBJ=277,
CEE_UNUSED68=278,
CEE_CPBLK=279,
CEE_INITBLK=280,
CEE_UNUSED69=281,
CEE_RETHROW=282,
CEE_UNUSED51=283,
CEE_SIZEOF=284,
CEE_REFANYTYPE=285,
CEE_UNUSED52=286,
CEE_UNUSED53=287,
CEE_UNUSED54=288,
CEE_UNUSED55=289,
CEE_UNUSED70=290,
CEE_ILLEGAL=291,
CEE_MACRO_END=292,
CEE_COUNT=293
}
public class GenTables
{
	public static OpCodeTypeInfo[] opCodeTypeInfo = new OpCodeTypeInfo[]
	{ 
		new OpCodeTypeInfo("nop",0,1,255,0),
		new OpCodeTypeInfo("break",0,1,255,1),
		new OpCodeTypeInfo("ldarg.0",0,1,255,2),
		new OpCodeTypeInfo("ldarg.1",0,1,255,3),
		new OpCodeTypeInfo("ldarg.2",0,1,255,4),
		new OpCodeTypeInfo("ldarg.3",0,1,255,5),
		new OpCodeTypeInfo("ldloc.0",0,1,255,6),
		new OpCodeTypeInfo("ldloc.1",0,1,255,7),
		new OpCodeTypeInfo("ldloc.2",0,1,255,8),
		new OpCodeTypeInfo("ldloc.3",0,1,255,9),
		new OpCodeTypeInfo("stloc.0",0,1,255,10),
		new OpCodeTypeInfo("stloc.1",0,1,255,11),
		new OpCodeTypeInfo("stloc.2",0,1,255,12),
		new OpCodeTypeInfo("stloc.3",0,1,255,13),
		new OpCodeTypeInfo("ldarg.s",17,1,255,14),
		new OpCodeTypeInfo("ldarga.s",17,1,255,15),
		new OpCodeTypeInfo("starg.s",17,1,255,16),
		new OpCodeTypeInfo("ldloc.s",17,1,255,17),
		new OpCodeTypeInfo("ldloca.s",17,1,255,18),
		new OpCodeTypeInfo("stloc.s",17,1,255,19),
		new OpCodeTypeInfo("ldnull",0,1,255,20),
		new OpCodeTypeInfo("ldc.i4.m1",0,1,255,21),
		new OpCodeTypeInfo("ldc.i4.0",0,1,255,22),
		new OpCodeTypeInfo("ldc.i4.1",0,1,255,23),
		new OpCodeTypeInfo("ldc.i4.2",0,1,255,24),
		new OpCodeTypeInfo("ldc.i4.3",0,1,255,25),
		new OpCodeTypeInfo("ldc.i4.4",0,1,255,26),
		new OpCodeTypeInfo("ldc.i4.5",0,1,255,27),
		new OpCodeTypeInfo("ldc.i4.6",0,1,255,28),
		new OpCodeTypeInfo("ldc.i4.7",0,1,255,29),
		new OpCodeTypeInfo("ldc.i4.8",0,1,255,30),
		new OpCodeTypeInfo("ldc.i4.s",18,1,255,31),
		new OpCodeTypeInfo("ldc.i4",2,1,255,32),
		new OpCodeTypeInfo("ldc.i8",5,1,255,33),
		new OpCodeTypeInfo("ldc.r4",19,1,255,34),
		new OpCodeTypeInfo("ldc.r8",3,1,255,35),
		new OpCodeTypeInfo("unused",0,1,255,36),
		new OpCodeTypeInfo("dup",0,1,255,37),
		new OpCodeTypeInfo("pop",0,1,255,38),
		new OpCodeTypeInfo("jmp",6,1,255,39),
		new OpCodeTypeInfo("call",6,1,255,40),
		new OpCodeTypeInfo("calli",10,1,255,41),
		new OpCodeTypeInfo("ret",0,1,255,42),
		new OpCodeTypeInfo("br.s",20,1,255,43),
		new OpCodeTypeInfo("brfalse.s",20,1,255,44),
		new OpCodeTypeInfo("brtrue.s",20,1,255,45),
		new OpCodeTypeInfo("beq.s",20,1,255,46),
		new OpCodeTypeInfo("bge.s",20,1,255,47),
		new OpCodeTypeInfo("bgt.s",20,1,255,48),
		new OpCodeTypeInfo("ble.s",20,1,255,49),
		new OpCodeTypeInfo("blt.s",20,1,255,50),
		new OpCodeTypeInfo("bne.un.s",20,1,255,51),
		new OpCodeTypeInfo("bge.un.s",20,1,255,52),
		new OpCodeTypeInfo("bgt.un.s",20,1,255,53),
		new OpCodeTypeInfo("ble.un.s",20,1,255,54),
		new OpCodeTypeInfo("blt.un.s",20,1,255,55),
		new OpCodeTypeInfo("br",4,1,255,56),
		new OpCodeTypeInfo("brfalse",4,1,255,57),
		new OpCodeTypeInfo("brtrue",4,1,255,58),
		new OpCodeTypeInfo("beq",4,1,255,59),
		new OpCodeTypeInfo("bge",4,1,255,60),
		new OpCodeTypeInfo("bgt",4,1,255,61),
		new OpCodeTypeInfo("ble",4,1,255,62),
		new OpCodeTypeInfo("blt",4,1,255,63),
		new OpCodeTypeInfo("bne.un",4,1,255,64),
		new OpCodeTypeInfo("bge.un",4,1,255,65),
		new OpCodeTypeInfo("bgt.un",4,1,255,66),
		new OpCodeTypeInfo("ble.un",4,1,255,67),
		new OpCodeTypeInfo("blt.un",4,1,255,68),
		new OpCodeTypeInfo("switch",13,1,255,69),
		new OpCodeTypeInfo("ldind.i1",0,1,255,70),
		new OpCodeTypeInfo("ldind.u1",0,1,255,71),
		new OpCodeTypeInfo("ldind.i2",0,1,255,72),
		new OpCodeTypeInfo("ldind.u2",0,1,255,73),
		new OpCodeTypeInfo("ldind.i4",0,1,255,74),
		new OpCodeTypeInfo("ldind.u4",0,1,255,75),
		new OpCodeTypeInfo("ldind.i8",0,1,255,76),
		new OpCodeTypeInfo("ldind.i",0,1,255,77),
		new OpCodeTypeInfo("ldind.r4",0,1,255,78),
		new OpCodeTypeInfo("ldind.r8",0,1,255,79),
		new OpCodeTypeInfo("ldind.ref",0,1,255,80),
		new OpCodeTypeInfo("stind.ref",0,1,255,81),
		new OpCodeTypeInfo("stind.i1",0,1,255,82),
		new OpCodeTypeInfo("stind.i2",0,1,255,83),
		new OpCodeTypeInfo("stind.i4",0,1,255,84),
		new OpCodeTypeInfo("stind.i8",0,1,255,85),
		new OpCodeTypeInfo("stind.r4",0,1,255,86),
		new OpCodeTypeInfo("stind.r8",0,1,255,87),
		new OpCodeTypeInfo("add",0,1,255,88),
		new OpCodeTypeInfo("sub",0,1,255,89),
		new OpCodeTypeInfo("mul",0,1,255,90),
		new OpCodeTypeInfo("div",0,1,255,91),
		new OpCodeTypeInfo("div.un",0,1,255,92),
		new OpCodeTypeInfo("rem",0,1,255,93),
		new OpCodeTypeInfo("rem.un",0,1,255,94),
		new OpCodeTypeInfo("and",0,1,255,95),
		new OpCodeTypeInfo("or",0,1,255,96),
		new OpCodeTypeInfo("xor",0,1,255,97),
		new OpCodeTypeInfo("shl",0,1,255,98),
		new OpCodeTypeInfo("shr",0,1,255,99),
		new OpCodeTypeInfo("shr.un",0,1,255,100),
		new OpCodeTypeInfo("neg",0,1,255,101),
		new OpCodeTypeInfo("not",0,1,255,102),
		new OpCodeTypeInfo("conv.i1",0,1,255,103),
		new OpCodeTypeInfo("conv.i2",0,1,255,104),
		new OpCodeTypeInfo("conv.i4",0,1,255,105),
		new OpCodeTypeInfo("conv.i8",0,1,255,106),
		new OpCodeTypeInfo("conv.r4",0,1,255,107),
		new OpCodeTypeInfo("conv.r8",0,1,255,108),
		new OpCodeTypeInfo("conv.u4",0,1,255,109),
		new OpCodeTypeInfo("conv.u8",0,1,255,110),
		new OpCodeTypeInfo("callvirt",6,1,255,111),
		new OpCodeTypeInfo("cpobj",8,1,255,112),
		new OpCodeTypeInfo("ldobj",8,1,255,113),
		new OpCodeTypeInfo("ldstr",9,1,255,114),
		new OpCodeTypeInfo("newobj",6,1,255,115),
		new OpCodeTypeInfo("castclass",8,1,255,116),
		new OpCodeTypeInfo("isinst",8,1,255,117),
		new OpCodeTypeInfo("conv.r.un",0,1,255,118),
		new OpCodeTypeInfo("unused",0,1,255,119),
		new OpCodeTypeInfo("unused",0,1,255,120),
		new OpCodeTypeInfo("unbox",8,1,255,121),
		new OpCodeTypeInfo("throw",0,1,255,122),
		new OpCodeTypeInfo("ldfld",7,1,255,123),
		new OpCodeTypeInfo("ldflda",7,1,255,124),
		new OpCodeTypeInfo("stfld",7,1,255,125),
		new OpCodeTypeInfo("ldsfld",7,1,255,126),
		new OpCodeTypeInfo("ldsflda",7,1,255,127),
		new OpCodeTypeInfo("stsfld",7,1,255,128),
		new OpCodeTypeInfo("stobj",8,1,255,129),
		new OpCodeTypeInfo("conv.ovf.i1.un",0,1,255,130),
		new OpCodeTypeInfo("conv.ovf.i2.un",0,1,255,131),
		new OpCodeTypeInfo("conv.ovf.i4.un",0,1,255,132),
		new OpCodeTypeInfo("conv.ovf.i8.un",0,1,255,133),
		new OpCodeTypeInfo("conv.ovf.u1.un",0,1,255,134),
		new OpCodeTypeInfo("conv.ovf.u2.un",0,1,255,135),
		new OpCodeTypeInfo("conv.ovf.u4.un",0,1,255,136),
		new OpCodeTypeInfo("conv.ovf.u8.un",0,1,255,137),
		new OpCodeTypeInfo("conv.ovf.i.un",0,1,255,138),
		new OpCodeTypeInfo("conv.ovf.u.un",0,1,255,139),
		new OpCodeTypeInfo("box",8,1,255,140),
		new OpCodeTypeInfo("newarr",8,1,255,141),
		new OpCodeTypeInfo("ldlen",0,1,255,142),
		new OpCodeTypeInfo("ldelema",8,1,255,143),
		new OpCodeTypeInfo("ldelem.i1",0,1,255,144),
		new OpCodeTypeInfo("ldelem.u1",0,1,255,145),
		new OpCodeTypeInfo("ldelem.i2",0,1,255,146),
		new OpCodeTypeInfo("ldelem.u2",0,1,255,147),
		new OpCodeTypeInfo("ldelem.i4",0,1,255,148),
		new OpCodeTypeInfo("ldelem.u4",0,1,255,149),
		new OpCodeTypeInfo("ldelem.i8",0,1,255,150),
		new OpCodeTypeInfo("ldelem.i",0,1,255,151),
		new OpCodeTypeInfo("ldelem.r4",0,1,255,152),
		new OpCodeTypeInfo("ldelem.r8",0,1,255,153),
		new OpCodeTypeInfo("ldelem.ref",0,1,255,154),
		new OpCodeTypeInfo("stelem.i",0,1,255,155),
		new OpCodeTypeInfo("stelem.i1",0,1,255,156),
		new OpCodeTypeInfo("stelem.i2",0,1,255,157),
		new OpCodeTypeInfo("stelem.i4",0,1,255,158),
		new OpCodeTypeInfo("stelem.i8",0,1,255,159),
		new OpCodeTypeInfo("stelem.r4",0,1,255,160),
		new OpCodeTypeInfo("stelem.r8",0,1,255,161),
		new OpCodeTypeInfo("stelem.ref",0,1,255,162),
		new OpCodeTypeInfo("unused",0,1,255,163),
		new OpCodeTypeInfo("unused",0,1,255,164),
		new OpCodeTypeInfo("unused",0,1,255,165),
		new OpCodeTypeInfo("unused",0,1,255,166),
		new OpCodeTypeInfo("unused",0,1,255,167),
		new OpCodeTypeInfo("unused",0,1,255,168),
		new OpCodeTypeInfo("unused",0,1,255,169),
		new OpCodeTypeInfo("unused",0,1,255,170),
		new OpCodeTypeInfo("unused",0,1,255,171),
		new OpCodeTypeInfo("unused",0,1,255,172),
		new OpCodeTypeInfo("unused",0,1,255,173),
		new OpCodeTypeInfo("unused",0,1,255,174),
		new OpCodeTypeInfo("unused",0,1,255,175),
		new OpCodeTypeInfo("unused",0,1,255,176),
		new OpCodeTypeInfo("unused",0,1,255,177),
		new OpCodeTypeInfo("unused",0,1,255,178),
		new OpCodeTypeInfo("conv.ovf.i1",0,1,255,179),
		new OpCodeTypeInfo("conv.ovf.u1",0,1,255,180),
		new OpCodeTypeInfo("conv.ovf.i2",0,1,255,181),
		new OpCodeTypeInfo("conv.ovf.u2",0,1,255,182),
		new OpCodeTypeInfo("conv.ovf.i4",0,1,255,183),
		new OpCodeTypeInfo("conv.ovf.u4",0,1,255,184),
		new OpCodeTypeInfo("conv.ovf.i8",0,1,255,185),
		new OpCodeTypeInfo("conv.ovf.u8",0,1,255,186),
		new OpCodeTypeInfo("unused",0,1,255,187),
		new OpCodeTypeInfo("unused",0,1,255,188),
		new OpCodeTypeInfo("unused",0,1,255,189),
		new OpCodeTypeInfo("unused",0,1,255,190),
		new OpCodeTypeInfo("unused",0,1,255,191),
		new OpCodeTypeInfo("unused",0,1,255,192),
		new OpCodeTypeInfo("unused",0,1,255,193),
		new OpCodeTypeInfo("refanyval",8,1,255,194),
		new OpCodeTypeInfo("ckfinite",0,1,255,195),
		new OpCodeTypeInfo("unused",0,1,255,196),
		new OpCodeTypeInfo("unused",0,1,255,197),
		new OpCodeTypeInfo("mkrefany",8,1,255,198),
		new OpCodeTypeInfo("unused",0,1,255,199),
		new OpCodeTypeInfo("unused",0,1,255,200),
		new OpCodeTypeInfo("unused",0,1,255,201),
		new OpCodeTypeInfo("unused",0,1,255,202),
		new OpCodeTypeInfo("unused",0,1,255,203),
		new OpCodeTypeInfo("unused",0,1,255,204),
		new OpCodeTypeInfo("unused",0,1,255,205),
		new OpCodeTypeInfo("unused",0,1,255,206),
		new OpCodeTypeInfo("unused",0,1,255,207),
		new OpCodeTypeInfo("ldtoken",12,1,255,208),
		new OpCodeTypeInfo("conv.u2",0,1,255,209),
		new OpCodeTypeInfo("conv.u1",0,1,255,210),
		new OpCodeTypeInfo("conv.i",0,1,255,211),
		new OpCodeTypeInfo("conv.ovf.i",0,1,255,212),
		new OpCodeTypeInfo("conv.ovf.u",0,1,255,213),
		new OpCodeTypeInfo("add.ovf",0,1,255,214),
		new OpCodeTypeInfo("add.ovf.un",0,1,255,215),
		new OpCodeTypeInfo("mul.ovf",0,1,255,216),
		new OpCodeTypeInfo("mul.ovf.un",0,1,255,217),
		new OpCodeTypeInfo("sub.ovf",0,1,255,218),
		new OpCodeTypeInfo("sub.ovf.un",0,1,255,219),
		new OpCodeTypeInfo("endfinally",0,1,255,220),
		new OpCodeTypeInfo("leave",4,1,255,221),
		new OpCodeTypeInfo("leave.s",20,1,255,222),
		new OpCodeTypeInfo("stind.i",0,1,255,223),
		new OpCodeTypeInfo("conv.u",0,1,255,224),
		new OpCodeTypeInfo("unused",0,1,255,225),
		new OpCodeTypeInfo("unused",0,1,255,226),
		new OpCodeTypeInfo("unused",0,1,255,227),
		new OpCodeTypeInfo("unused",0,1,255,228),
		new OpCodeTypeInfo("unused",0,1,255,229),
		new OpCodeTypeInfo("unused",0,1,255,230),
		new OpCodeTypeInfo("unused",0,1,255,231),
		new OpCodeTypeInfo("unused",0,1,255,232),
		new OpCodeTypeInfo("unused",0,1,255,233),
		new OpCodeTypeInfo("unused",0,1,255,234),
		new OpCodeTypeInfo("unused",0,1,255,235),
		new OpCodeTypeInfo("unused",0,1,255,236),
		new OpCodeTypeInfo("unused",0,1,255,237),
		new OpCodeTypeInfo("unused",0,1,255,238),
		new OpCodeTypeInfo("unused",0,1,255,239),
		new OpCodeTypeInfo("unused",0,1,255,240),
		new OpCodeTypeInfo("unused",0,1,255,241),
		new OpCodeTypeInfo("unused",0,1,255,242),
		new OpCodeTypeInfo("unused",0,1,255,243),
		new OpCodeTypeInfo("unused",0,1,255,244),
		new OpCodeTypeInfo("unused",0,1,255,245),
		new OpCodeTypeInfo("unused",0,1,255,246),
		new OpCodeTypeInfo("unused",0,1,255,247),
		new OpCodeTypeInfo("prefix7",0,1,255,248),
		new OpCodeTypeInfo("prefix6",0,1,255,249),
		new OpCodeTypeInfo("prefix5",0,1,255,250),
		new OpCodeTypeInfo("prefix4",0,1,255,251),
		new OpCodeTypeInfo("prefix3",0,1,255,252),
		new OpCodeTypeInfo("prefix2",0,1,255,253),
		new OpCodeTypeInfo("prefix1",0,1,255,254),
		new OpCodeTypeInfo("prefixref",0,1,255,255),
		new OpCodeTypeInfo("arglist",0,2,254,0),
		new OpCodeTypeInfo("ceq",0,2,254,1),
		new OpCodeTypeInfo("cgt",0,2,254,2),
		new OpCodeTypeInfo("cgt.un",0,2,254,3),
		new OpCodeTypeInfo("clt",0,2,254,4),
		new OpCodeTypeInfo("clt.un",0,2,254,5),
		new OpCodeTypeInfo("ldftn",6,2,254,6),
		new OpCodeTypeInfo("ldvirtftn",6,2,254,7),
		new OpCodeTypeInfo("unused",0,2,254,8),
		new OpCodeTypeInfo("ldarg",1,2,254,9),
		new OpCodeTypeInfo("ldarga",1,2,254,10),
		new OpCodeTypeInfo("starg",1,2,254,11),
		new OpCodeTypeInfo("ldloc",1,2,254,12),
		new OpCodeTypeInfo("ldloca",1,2,254,13),
		new OpCodeTypeInfo("stloc",1,2,254,14),
		new OpCodeTypeInfo("localloc",0,2,254,15),
		new OpCodeTypeInfo("unused",0,2,254,16),
		new OpCodeTypeInfo("endfilter",0,2,254,17),
		new OpCodeTypeInfo("unaligned.",18,2,254,18),
		new OpCodeTypeInfo("volatile.",0,2,254,19),
		new OpCodeTypeInfo("tail.",0,2,254,20),
		new OpCodeTypeInfo("initobj",8,2,254,21),
		new OpCodeTypeInfo("unused",0,2,254,22),
		new OpCodeTypeInfo("cpblk",0,2,254,23),
		new OpCodeTypeInfo("initblk",0,2,254,24),
		new OpCodeTypeInfo("unused",0,2,254,25),
		new OpCodeTypeInfo("rethrow",0,2,254,26),
		new OpCodeTypeInfo("unused",0,2,254,27),
		new OpCodeTypeInfo("sizeof",8,2,254,28),
		new OpCodeTypeInfo("refanytype",0,2,254,29),
		new OpCodeTypeInfo("unused",0,2,254,30),
		new OpCodeTypeInfo("unused",0,2,254,31),
		new OpCodeTypeInfo("unused",0,2,254,32),
		new OpCodeTypeInfo("unused",0,2,254,33),
		new OpCodeTypeInfo("unused",0,2,254,34),
		new OpCodeTypeInfo("illegal",0,0,0,0),
		new OpCodeTypeInfo("endmac",0,0,0,0),
		new OpCodeTypeInfo("brnull",0,0,0,0),
		new OpCodeTypeInfo("brnull.s",0,0,0,0),
		new OpCodeTypeInfo("brzero",0,0,0,0),
		new OpCodeTypeInfo("brzero.s",0,0,0,0),
		new OpCodeTypeInfo("brinst",0,0,0,0),
		new OpCodeTypeInfo("brinst.s",0,0,0,0),
		new OpCodeTypeInfo("ldind.u8",0,0,0,0),
		new OpCodeTypeInfo("ldelem.u8",0,0,0,0),
		new OpCodeTypeInfo("ldc.i4.M1",0,0,0,0),
		new OpCodeTypeInfo("endfault",0,0,0,0)
	};
}
										
}														
