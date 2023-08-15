#include "TypeDefs.h"

#include "SimplSig.h"

   #include "C:\Users\Paul\Desktop\Salem HS 4-22-19\cpp-3\1526320_Salem_HS_GLP3-1_Library 03-22-2019_compiled\SPlsWork\S2_Photocell_Proportional_Control_v1_7.h"


union Globals_u
{
   GLOBAL_VAR_STRUCT( S2_Photocell_Proportional_Control_v1_7 );
};


union Nvram_u
{
   NVRAM_VAR_STRUCT( S2_Photocell_Proportional_Control_v1_7 );
};


register union Globals_u *Globals asm ("%a5");
register union Nvram_u *Nvram asm ("%a4");


