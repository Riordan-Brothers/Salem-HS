NAME	= examples

CC      = m68k-elf-gcc
CXX     = m68k-elf-g++
LD      = m68k-elf-ld

# IMPORTANT : Uncomment the three lines below that correspond to your board.
#
# These examples support the SBC5206, SBC5206e, SBC5307 and sbc5206eLite
# set the VARIANT environment var to pick your board type

ifeq "$(strip $(VARIANT))" ""
  VARIANT=sbc5307
endif

# pattern match the variant to set the compiler flags

CPU_VARIANT=MCF5307
NEW_INSTRUCTIONS=-mmac -mhwdiv
SIMINFO=siminfo2.elf
MACTEST=mactest.elf

# Environment variable CPUTYPE should be set to STANDARDFLASH or LARGEFLASH.  If none,
# we will use STANDARDFLASH.
# standardflash.ld - uses 2 Meg SIMPL+ size
# largeflash.ld - uses 1 Meg SIMPL+ size
# ifeq "$(CPUTYPE)" "STANDARDFLASH"
#  LINKER_SCRIPT=standardflash.ld
# else 
# ifeq "$(CPUTYPE)" "LARGEFLASH"
#   LINKER_SCRIPT=largeflash.ld
# else
#   LINKER_SCRIPT=standardflash.ld
# endif
# endif

# We're setting the LD file to have a very large target link size.  The tools will catch it since they
# will accurate read the SPL file size from the internal Program Header.  In this way, GNU won't stop
# with an error that we have trouble trapping.
LINKER_SCRIPT=bigram.ld

#PIC_FLAGS = -fpic
PIC_FLAGS =
CFLAGS = -m5200 $(PIC_FLAGS) -D$(CPU_VARIANT) $(NEW_INSTRUCTIONS) -w
#CFLAGS = -m5200 $(NEW_INSTRUCTIONS) -D$(CPU_VARIANT) -DVARIANT_$(VARIANT)
#LDFLAGS = -m5200 $(NEW_INSTRUCTIONS) -T$(LINKER_SCRIPT) -Wl,-Map=$(basename $@).map
LDFLAGS = -T$(LINKER_SCRIPT) -Map=$(basename $@).map -nostartup -nodefaultlibs

CFLAGS += -I../../include

ifeq "$(DEBUG)" "1"
  CFLAGS += -gdwarf -DDEBUG_MODE_FLAG=1
else
# Remove the omit frame pointer option so that we can trace through the stack
#  CFLAGS += -O4 -fomit-frame-pointer
  CFLAGS += -O3
  LDFLAGS += -s -n
endif

#__SPLS_INSERT_INCL_FILES__ INCLUDES = library.h typedefs.h FnctList.h SimplSig.h
INCLUDES = library.h typedefs.h FnctList.h SimplSig.h

#__SPLS_INSERT_OBJ_FILES__
OBJECTS = S2_Photocell_Proportional_Control_v1_7.o 

ifeq "$(DEBUG)" "1"
  OBJECTS += Library_inline.o 
endif


#__SPLS_INSERT_LINKOUTPUT_FILE__
all: _S2_1526320_Salem_HS_GLP3_1_Library_04_22_2019.spl


crt0.o: crt0.s
	$(CC) $(CFLAGS) -x assembler-with-cpp -Wall $< -c -o $@

#__SPLS_INSERT_TARGET_FILES__ $(CC) $(CFLAGS) -Wall $< -c -o $@


globals.o: globals.c globals.h
	$(CC) $(CFLAGS) -Wall $< -c -o $@

#this should be made a library archive
library.o: library.c library.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@

Library_inline.o: library_inline.c library_inline.h $(INCLUDES)
	$(CC) $(CFLAGS) -Wall $< -c -o $@
	
#__SPLS_INSERT_LINK_CMD__ $(OBJECTS) globals.o library.o
_S2_1526320_Salem_HS_GLP3_1_Library_04_22_2019.spl: 	$(OBJECTS) globals.o library.o
	$(LD) $(LDFLAGS) -o $@ $(OBJECTS) globals.o library.o
  ifeq "$(DEBUG)" "1"
	  cp $@ $@.elf
  endif
	AddHeader $@ -d:6

#__SPLS_INSERT_HDR_FILES__
globals.h: S2_Photocell_Proportional_Control_v1_7.h 

