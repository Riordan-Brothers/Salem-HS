using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;
using GLPP_Helper;

namespace UserModule_RBI_GLPP_HELPER_SPLUS_V4
{
    public class UserModuleClass_RBI_GLPP_HELPER_SPLUS_V4 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SAVE;
        Crestron.Logos.SplusObjects.DigitalInput NEWLOCALMOTION;
        Crestron.Logos.SplusObjects.AnalogInput UPDATETIMEOUT;
        Crestron.Logos.SplusObjects.AnalogInput NEWOCCUPANCYACTION;
        Crestron.Logos.SplusObjects.AnalogInput NEWVACATINGACTION;
        Crestron.Logos.SplusObjects.StringInput NEWROOMNAME;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> NEWZONENAME;
        Crestron.Logos.SplusObjects.DigitalOutput UPDATEPULSE;
        Crestron.Logos.SplusObjects.DigitalOutput SAVEDPULSE;
        Crestron.Logos.SplusObjects.AnalogOutput SAVESTATUS;
        Crestron.Logos.SplusObjects.DigitalOutput DEFEATLOCALMOTIONLOGIC;
        Crestron.Logos.SplusObjects.AnalogOutput SETTIMEOUT;
        Crestron.Logos.SplusObjects.AnalogOutput UPDATETIMEOUTMINUTES;
        Crestron.Logos.SplusObjects.AnalogOutput OCCUPANCYACTION;
        Crestron.Logos.SplusObjects.AnalogOutput VACATINGACTION;
        Crestron.Logos.SplusObjects.StringOutput ROOMNAME__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ZONENAME;
        StringParameter ROOMID;
        GLPP_Helper.XML_Helper HELPER;
        public void HANDLEDATACHANGE ( object __sender__ /*GLPP_Helper.XML_Helper P */, GLPP_Helper.GLPPEventArgs ARGS ) 
            { 
            XML_Helper  P  = (XML_Helper )__sender__;
            ushort I = 0;
            
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 61;
                DEFEATLOCALMOTIONLOGIC  .Value = (ushort) ( ARGS.glppSettings.DefeatLocalMotion ) ; 
                __context__.SourceCodeLine = 62;
                SETTIMEOUT  .Value = (ushort) ( ARGS.glppSettings.SetTimeout ) ; 
                __context__.SourceCodeLine = 63;
                OCCUPANCYACTION  .Value = (ushort) ( ARGS.glppSettings.OccupancyAction ) ; 
                __context__.SourceCodeLine = 64;
                VACATINGACTION  .Value = (ushort) ( ARGS.glppSettings.VacatingAction ) ; 
                __context__.SourceCodeLine = 65;
                ROOMNAME__DOLLAR__  .UpdateValue ( ARGS . glppSettings . RoomName  ) ; 
                __context__.SourceCodeLine = 69;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)8; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 71;
                    ZONENAME [ I]  .UpdateValue ( ARGS . glppSettings . ZoneNames [ (I - 1) ]  ) ; 
                    __context__.SourceCodeLine = 69;
                    } 
                
                __context__.SourceCodeLine = 76;
                Functions.Pulse ( 50, UPDATEPULSE ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object NEWROOMNAME_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 84;
                HELPER . setName ( NEWROOMNAME .ToString()) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object NEWZONENAME_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 92;
            I = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 94;
            HELPER . setZoneName ( (ushort)( (I - 1) ), NEWZONENAME[ I ] .ToString()) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object NEWLOCALMOTION_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 102;
        HELPER . setLocalMotion ( (ushort)( NEWLOCALMOTION  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UPDATETIMEOUT_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 111;
        HELPER . setTimeout ( (ushort)( UPDATETIMEOUT  .UshortValue )) ; 
        __context__.SourceCodeLine = 112;
        UPDATETIMEOUTMINUTES  .Value = (ushort) ( (UPDATETIMEOUT  .UshortValue / 600) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEWOCCUPANCYACTION_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 122;
        HELPER . setOccupancyAction ( (ushort)( NEWOCCUPANCYACTION  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NEWVACATINGACTION_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 129;
        HELPER . setOccupancyAction ( (ushort)( NEWVACATINGACTION  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SAVE_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort SAVESTATUS = 0;
        
        
        __context__.SourceCodeLine = 142;
        SAVESTATUS = (ushort) ( HELPER.updateXML() ) ; 
        __context__.SourceCodeLine = 146;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SAVESTATUS == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 148;
            Functions.Pulse ( 50, SAVEDPULSE ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 165;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 167;
        // RegisterEvent( HELPER , ONDATACHANGE , HANDLEDATACHANGE ) 
        try { g_criticalSection.Enter(); HELPER .OnDataChange  += HANDLEDATACHANGE; } finally { g_criticalSection.Leave(); }
        ; 
        __context__.SourceCodeLine = 168;
        HELPER . Initialize ( ROOMID  .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    SAVE = new Crestron.Logos.SplusObjects.DigitalInput( SAVE__DigitalInput__, this );
    m_DigitalInputList.Add( SAVE__DigitalInput__, SAVE );
    
    NEWLOCALMOTION = new Crestron.Logos.SplusObjects.DigitalInput( NEWLOCALMOTION__DigitalInput__, this );
    m_DigitalInputList.Add( NEWLOCALMOTION__DigitalInput__, NEWLOCALMOTION );
    
    UPDATEPULSE = new Crestron.Logos.SplusObjects.DigitalOutput( UPDATEPULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( UPDATEPULSE__DigitalOutput__, UPDATEPULSE );
    
    SAVEDPULSE = new Crestron.Logos.SplusObjects.DigitalOutput( SAVEDPULSE__DigitalOutput__, this );
    m_DigitalOutputList.Add( SAVEDPULSE__DigitalOutput__, SAVEDPULSE );
    
    DEFEATLOCALMOTIONLOGIC = new Crestron.Logos.SplusObjects.DigitalOutput( DEFEATLOCALMOTIONLOGIC__DigitalOutput__, this );
    m_DigitalOutputList.Add( DEFEATLOCALMOTIONLOGIC__DigitalOutput__, DEFEATLOCALMOTIONLOGIC );
    
    UPDATETIMEOUT = new Crestron.Logos.SplusObjects.AnalogInput( UPDATETIMEOUT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( UPDATETIMEOUT__AnalogSerialInput__, UPDATETIMEOUT );
    
    NEWOCCUPANCYACTION = new Crestron.Logos.SplusObjects.AnalogInput( NEWOCCUPANCYACTION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NEWOCCUPANCYACTION__AnalogSerialInput__, NEWOCCUPANCYACTION );
    
    NEWVACATINGACTION = new Crestron.Logos.SplusObjects.AnalogInput( NEWVACATINGACTION__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NEWVACATINGACTION__AnalogSerialInput__, NEWVACATINGACTION );
    
    SAVESTATUS = new Crestron.Logos.SplusObjects.AnalogOutput( SAVESTATUS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SAVESTATUS__AnalogSerialOutput__, SAVESTATUS );
    
    SETTIMEOUT = new Crestron.Logos.SplusObjects.AnalogOutput( SETTIMEOUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SETTIMEOUT__AnalogSerialOutput__, SETTIMEOUT );
    
    UPDATETIMEOUTMINUTES = new Crestron.Logos.SplusObjects.AnalogOutput( UPDATETIMEOUTMINUTES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( UPDATETIMEOUTMINUTES__AnalogSerialOutput__, UPDATETIMEOUTMINUTES );
    
    OCCUPANCYACTION = new Crestron.Logos.SplusObjects.AnalogOutput( OCCUPANCYACTION__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( OCCUPANCYACTION__AnalogSerialOutput__, OCCUPANCYACTION );
    
    VACATINGACTION = new Crestron.Logos.SplusObjects.AnalogOutput( VACATINGACTION__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VACATINGACTION__AnalogSerialOutput__, VACATINGACTION );
    
    NEWROOMNAME = new Crestron.Logos.SplusObjects.StringInput( NEWROOMNAME__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( NEWROOMNAME__AnalogSerialInput__, NEWROOMNAME );
    
    NEWZONENAME = new InOutArray<StringInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        NEWZONENAME[i+1] = new Crestron.Logos.SplusObjects.StringInput( NEWZONENAME__AnalogSerialInput__ + i, NEWZONENAME__AnalogSerialInput__, 100, this );
        m_StringInputList.Add( NEWZONENAME__AnalogSerialInput__ + i, NEWZONENAME[i+1] );
    }
    
    ROOMNAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( ROOMNAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOMNAME__DOLLAR____AnalogSerialOutput__, ROOMNAME__DOLLAR__ );
    
    ZONENAME = new InOutArray<StringOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        ZONENAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ZONENAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ZONENAME__AnalogSerialOutput__ + i, ZONENAME[i+1] );
    }
    
    ROOMID = new StringParameter( ROOMID__Parameter__, this );
    m_ParameterList.Add( ROOMID__Parameter__, ROOMID );
    
    
    NEWROOMNAME.OnSerialChange.Add( new InputChangeHandlerWrapper( NEWROOMNAME_OnChange_0, true ) );
    for( uint i = 0; i < 8; i++ )
        NEWZONENAME[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( NEWZONENAME_OnChange_1, true ) );
        
    NEWLOCALMOTION.OnDigitalChange.Add( new InputChangeHandlerWrapper( NEWLOCALMOTION_OnChange_2, false ) );
    UPDATETIMEOUT.OnAnalogChange.Add( new InputChangeHandlerWrapper( UPDATETIMEOUT_OnChange_3, true ) );
    NEWOCCUPANCYACTION.OnAnalogChange.Add( new InputChangeHandlerWrapper( NEWOCCUPANCYACTION_OnChange_4, true ) );
    NEWVACATINGACTION.OnAnalogChange.Add( new InputChangeHandlerWrapper( NEWVACATINGACTION_OnChange_5, true ) );
    SAVE.OnDigitalPush.Add( new InputChangeHandlerWrapper( SAVE_OnPush_6, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    HELPER  = new GLPP_Helper.XML_Helper();
    
    
}

public UserModuleClass_RBI_GLPP_HELPER_SPLUS_V4 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SAVE__DigitalInput__ = 0;
const uint NEWLOCALMOTION__DigitalInput__ = 1;
const uint UPDATETIMEOUT__AnalogSerialInput__ = 0;
const uint NEWOCCUPANCYACTION__AnalogSerialInput__ = 1;
const uint NEWVACATINGACTION__AnalogSerialInput__ = 2;
const uint NEWROOMNAME__AnalogSerialInput__ = 3;
const uint NEWZONENAME__AnalogSerialInput__ = 4;
const uint UPDATEPULSE__DigitalOutput__ = 0;
const uint SAVEDPULSE__DigitalOutput__ = 1;
const uint SAVESTATUS__AnalogSerialOutput__ = 0;
const uint DEFEATLOCALMOTIONLOGIC__DigitalOutput__ = 2;
const uint SETTIMEOUT__AnalogSerialOutput__ = 1;
const uint UPDATETIMEOUTMINUTES__AnalogSerialOutput__ = 2;
const uint OCCUPANCYACTION__AnalogSerialOutput__ = 3;
const uint VACATINGACTION__AnalogSerialOutput__ = 4;
const uint ROOMNAME__DOLLAR____AnalogSerialOutput__ = 5;
const uint ZONENAME__AnalogSerialOutput__ = 6;
const uint ROOMID__Parameter__ = 10;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort NEWTIMEOUT = 0;
            
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
