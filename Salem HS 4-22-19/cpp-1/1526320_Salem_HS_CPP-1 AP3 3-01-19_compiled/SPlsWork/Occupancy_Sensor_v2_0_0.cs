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

namespace UserModule_OCCUPANCY_SENSOR_V2_0_0
{
    public class UserModuleClass_OCCUPANCY_SENSOR_V2_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SENSOR_OPENS_ON_MOTION;
        Crestron.Logos.SplusObjects.DigitalInput ENABLE;
        Crestron.Logos.SplusObjects.DigitalInput DISABLE;
        Crestron.Logos.SplusObjects.DigitalInput SENSOR_INPUT;
        Crestron.Logos.SplusObjects.DigitalInput FORCE_OCCUPANCY;
        Crestron.Logos.SplusObjects.DigitalInput FORCE_VACANCY;
        Crestron.Logos.SplusObjects.AnalogInput SENSOR_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalOutput ENABLED;
        Crestron.Logos.SplusObjects.DigitalOutput DISABLED;
        Crestron.Logos.SplusObjects.DigitalOutput OCCUPANCY_TRIGGER;
        Crestron.Logos.SplusObjects.DigitalOutput OCCUPANCY_FEEDBACK;
        Crestron.Logos.SplusObjects.DigitalOutput VACANCY_TRIGGER;
        Crestron.Logos.SplusObjects.DigitalOutput VACANCY_FEEDBACK;
        Crestron.Logos.SplusObjects.DigitalOutput OCCUPANCY_RAW;
        Crestron.Logos.SplusObjects.DigitalOutput VACANCY_RAW;
        object ENABLE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 31;
                DISABLED  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 32;
                ENABLED  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 34;
                if ( Functions.TestForTrue  ( ( Functions.Not( SENSOR_OPENS_ON_MOTION  .Value ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 36;
                    if ( Functions.TestForTrue  ( ( SENSOR_INPUT  .Value)  ) ) 
                        { 
                        __context__.SourceCodeLine = 38;
                        Functions.Pulse ( 10, OCCUPANCY_TRIGGER ) ; 
                        __context__.SourceCodeLine = 39;
                        VACANCY_FEEDBACK  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 40;
                        VACANCY_RAW  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 41;
                        OCCUPANCY_FEEDBACK  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 42;
                        OCCUPANCY_RAW  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 43;
                        _SplusNVRAM.IN_FORCE_VACANCY = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 47;
                        Functions.Pulse ( 10, VACANCY_TRIGGER ) ; 
                        __context__.SourceCodeLine = 48;
                        OCCUPANCY_FEEDBACK  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 49;
                        OCCUPANCY_RAW  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 50;
                        VACANCY_FEEDBACK  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 51;
                        VACANCY_RAW  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 52;
                        _SplusNVRAM.IN_FORCE_VACANCY = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 57;
                    if ( Functions.TestForTrue  ( ( Functions.Not( SENSOR_INPUT  .Value ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 59;
                        Functions.Pulse ( 10, OCCUPANCY_TRIGGER ) ; 
                        __context__.SourceCodeLine = 60;
                        VACANCY_FEEDBACK  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 61;
                        VACANCY_RAW  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 62;
                        OCCUPANCY_FEEDBACK  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 63;
                        OCCUPANCY_RAW  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 64;
                        _SplusNVRAM.IN_FORCE_VACANCY = (ushort) ( 0 ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 68;
                        Functions.Pulse ( 10, VACANCY_TRIGGER ) ; 
                        __context__.SourceCodeLine = 69;
                        OCCUPANCY_FEEDBACK  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 70;
                        OCCUPANCY_RAW  .Value = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 71;
                        VACANCY_FEEDBACK  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 72;
                        VACANCY_RAW  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 73;
                        _SplusNVRAM.IN_FORCE_VACANCY = (ushort) ( 0 ) ; 
                        } 
                    
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object DISABLE_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 80;
            ENABLED  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 81;
            DISABLED  .Value = (ushort) ( 1 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SENSOR_INPUT_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 86;
        if ( Functions.TestForTrue  ( ( Functions.Not( SENSOR_OPENS_ON_MOTION  .Value ))  ) ) 
            { 
            __context__.SourceCodeLine = 88;
            VACANCY_RAW  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 89;
            OCCUPANCY_RAW  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 90;
            _SplusNVRAM.IN_FORCE_VACANCY = (ushort) ( 0 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 94;
            OCCUPANCY_RAW  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 95;
            VACANCY_RAW  .Value = (ushort) ( 1 ) ; 
            } 
        
        __context__.SourceCodeLine = 98;
        if ( Functions.TestForTrue  ( ( ENABLED  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 101;
            if ( Functions.TestForTrue  ( ( Functions.Not( SENSOR_OPENS_ON_MOTION  .Value ))  ) ) 
                { 
                __context__.SourceCodeLine = 103;
                if ( Functions.TestForTrue  ( ( Functions.Not( _SplusNVRAM.TIMER_RUNNING ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 105;
                    Functions.Pulse ( 10, OCCUPANCY_TRIGGER ) ; 
                    __context__.SourceCodeLine = 106;
                    VACANCY_FEEDBACK  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 107;
                    OCCUPANCY_FEEDBACK  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 111;
                    _SplusNVRAM.TIMER_RUNNING = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 116;
                _SplusNVRAM.TIMER_RUNNING = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 118;
                if ( Functions.TestForTrue  ( ( _SplusNVRAM.IN_FORCE_VACANCY)  ) ) 
                    { 
                    __context__.SourceCodeLine = 120;
                    _SplusNVRAM.TIMER = (uint) ( 1 ) ; 
                    __context__.SourceCodeLine = 121;
                    _SplusNVRAM.IN_FORCE_VACANCY = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 125;
                    _SplusNVRAM.TIMER = (uint) ( (SENSOR_TIMEOUT  .UintValue + 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 128;
                do 
                    { 
                    __context__.SourceCodeLine = 130;
                    _SplusNVRAM.TIMER = (uint) ( (_SplusNVRAM.TIMER - 1) ) ; 
                    __context__.SourceCodeLine = 131;
                    Functions.Delay (  (int) ( 100 ) ) ; 
                    __context__.SourceCodeLine = 132;
                    if ( Functions.TestForTrue  ( ( OCCUPANCY_RAW  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 133;
                        break ; 
                        }
                    
                    } 
                while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (_SplusNVRAM.TIMER == 0)) )); 
                __context__.SourceCodeLine = 137;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( VACANCY_RAW  .Value ) && Functions.TestForTrue ( ENABLED  .Value )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 139;
                    _SplusNVRAM.TIMER_RUNNING = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 140;
                    Functions.Pulse ( 10, VACANCY_TRIGGER ) ; 
                    __context__.SourceCodeLine = 141;
                    OCCUPANCY_FEEDBACK  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 142;
                    VACANCY_FEEDBACK  .Value = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SENSOR_INPUT_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 150;
        if ( Functions.TestForTrue  ( ( Functions.Not( SENSOR_OPENS_ON_MOTION  .Value ))  ) ) 
            { 
            __context__.SourceCodeLine = 152;
            OCCUPANCY_RAW  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 153;
            VACANCY_RAW  .Value = (ushort) ( 1 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 157;
            VACANCY_RAW  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 158;
            OCCUPANCY_RAW  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 159;
            _SplusNVRAM.IN_FORCE_VACANCY = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 162;
        if ( Functions.TestForTrue  ( ( ENABLED  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 164;
            if ( Functions.TestForTrue  ( ( Functions.Not( SENSOR_OPENS_ON_MOTION  .Value ))  ) ) 
                { 
                __context__.SourceCodeLine = 166;
                if ( Functions.TestForTrue  ( ( _SplusNVRAM.IN_FORCE_VACANCY)  ) ) 
                    { 
                    __context__.SourceCodeLine = 168;
                    _SplusNVRAM.TIMER = (uint) ( 1 ) ; 
                    __context__.SourceCodeLine = 169;
                    _SplusNVRAM.IN_FORCE_VACANCY = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 173;
                    _SplusNVRAM.TIMER = (uint) ( (SENSOR_TIMEOUT  .UintValue + 1) ) ; 
                    } 
                
                __context__.SourceCodeLine = 176;
                _SplusNVRAM.TIMER_RUNNING = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 178;
                do 
                    { 
                    __context__.SourceCodeLine = 180;
                    _SplusNVRAM.TIMER = (uint) ( (_SplusNVRAM.TIMER - 1) ) ; 
                    __context__.SourceCodeLine = 181;
                    Functions.Delay (  (int) ( 100 ) ) ; 
                    __context__.SourceCodeLine = 182;
                    if ( Functions.TestForTrue  ( ( OCCUPANCY_RAW  .Value)  ) ) 
                        {
                        __context__.SourceCodeLine = 183;
                        break ; 
                        }
                    
                    } 
                while (false == ( Functions.TestForTrue  ( Functions.BoolToInt (_SplusNVRAM.TIMER == 0)) )); 
                __context__.SourceCodeLine = 187;
                if ( Functions.TestForTrue  ( ( Functions.Not( SENSOR_INPUT  .Value ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 189;
                    _SplusNVRAM.TIMER_RUNNING = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 190;
                    Functions.Pulse ( 10, VACANCY_TRIGGER ) ; 
                    __context__.SourceCodeLine = 191;
                    OCCUPANCY_FEEDBACK  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 192;
                    VACANCY_FEEDBACK  .Value = (ushort) ( 1 ) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 198;
                if ( Functions.TestForTrue  ( ( Functions.Not( _SplusNVRAM.TIMER_RUNNING ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 200;
                    Functions.Pulse ( 10, OCCUPANCY_TRIGGER ) ; 
                    __context__.SourceCodeLine = 201;
                    VACANCY_FEEDBACK  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 202;
                    OCCUPANCY_FEEDBACK  .Value = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 206;
                    _SplusNVRAM.TIMER_RUNNING = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FORCE_OCCUPANCY_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 214;
        VACANCY_RAW  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 215;
        OCCUPANCY_RAW  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 216;
        _SplusNVRAM.IN_FORCE_VACANCY = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FORCE_VACANCY_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 221;
        OCCUPANCY_RAW  .Value = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 222;
        VACANCY_RAW  .Value = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 223;
        _SplusNVRAM.IN_FORCE_VACANCY = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SENSOR_TIMEOUT_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 228;
        _SplusNVRAM.TIMER = (uint) ( (SENSOR_TIMEOUT  .UintValue + 1) ) ; 
        
        
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
        
        __context__.SourceCodeLine = 233;
        _SplusNVRAM.TIMER_RUNNING = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 234;
        _SplusNVRAM.IN_FORCE_VACANCY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 235;
        _SplusNVRAM.IN_FORCE_OCCUPANCY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 237;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 239;
        _SplusNVRAM.SENSOR_TYPE = (ushort) ( SENSOR_OPENS_ON_MOTION  .Value ) ; 
        __context__.SourceCodeLine = 241;
        if ( Functions.TestForTrue  ( ( Functions.Not( SENSOR_OPENS_ON_MOTION  .Value ))  ) ) 
            { 
            __context__.SourceCodeLine = 243;
            if ( Functions.TestForTrue  ( ( SENSOR_INPUT  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 245;
                VACANCY_FEEDBACK  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 246;
                VACANCY_RAW  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 247;
                OCCUPANCY_FEEDBACK  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 248;
                OCCUPANCY_RAW  .Value = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 252;
                OCCUPANCY_FEEDBACK  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 253;
                OCCUPANCY_RAW  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 254;
                VACANCY_FEEDBACK  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 255;
                VACANCY_RAW  .Value = (ushort) ( 1 ) ; 
                } 
            
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 260;
            if ( Functions.TestForTrue  ( ( SENSOR_INPUT  .Value)  ) ) 
                { 
                __context__.SourceCodeLine = 262;
                OCCUPANCY_FEEDBACK  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 263;
                OCCUPANCY_RAW  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 264;
                VACANCY_FEEDBACK  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 265;
                VACANCY_RAW  .Value = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 269;
                VACANCY_FEEDBACK  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 270;
                VACANCY_RAW  .Value = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 271;
                OCCUPANCY_FEEDBACK  .Value = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 272;
                OCCUPANCY_RAW  .Value = (ushort) ( 1 ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    SENSOR_OPENS_ON_MOTION = new Crestron.Logos.SplusObjects.DigitalInput( SENSOR_OPENS_ON_MOTION__DigitalInput__, this );
    m_DigitalInputList.Add( SENSOR_OPENS_ON_MOTION__DigitalInput__, SENSOR_OPENS_ON_MOTION );
    
    ENABLE = new Crestron.Logos.SplusObjects.DigitalInput( ENABLE__DigitalInput__, this );
    m_DigitalInputList.Add( ENABLE__DigitalInput__, ENABLE );
    
    DISABLE = new Crestron.Logos.SplusObjects.DigitalInput( DISABLE__DigitalInput__, this );
    m_DigitalInputList.Add( DISABLE__DigitalInput__, DISABLE );
    
    SENSOR_INPUT = new Crestron.Logos.SplusObjects.DigitalInput( SENSOR_INPUT__DigitalInput__, this );
    m_DigitalInputList.Add( SENSOR_INPUT__DigitalInput__, SENSOR_INPUT );
    
    FORCE_OCCUPANCY = new Crestron.Logos.SplusObjects.DigitalInput( FORCE_OCCUPANCY__DigitalInput__, this );
    m_DigitalInputList.Add( FORCE_OCCUPANCY__DigitalInput__, FORCE_OCCUPANCY );
    
    FORCE_VACANCY = new Crestron.Logos.SplusObjects.DigitalInput( FORCE_VACANCY__DigitalInput__, this );
    m_DigitalInputList.Add( FORCE_VACANCY__DigitalInput__, FORCE_VACANCY );
    
    ENABLED = new Crestron.Logos.SplusObjects.DigitalOutput( ENABLED__DigitalOutput__, this );
    m_DigitalOutputList.Add( ENABLED__DigitalOutput__, ENABLED );
    
    DISABLED = new Crestron.Logos.SplusObjects.DigitalOutput( DISABLED__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISABLED__DigitalOutput__, DISABLED );
    
    OCCUPANCY_TRIGGER = new Crestron.Logos.SplusObjects.DigitalOutput( OCCUPANCY_TRIGGER__DigitalOutput__, this );
    m_DigitalOutputList.Add( OCCUPANCY_TRIGGER__DigitalOutput__, OCCUPANCY_TRIGGER );
    
    OCCUPANCY_FEEDBACK = new Crestron.Logos.SplusObjects.DigitalOutput( OCCUPANCY_FEEDBACK__DigitalOutput__, this );
    m_DigitalOutputList.Add( OCCUPANCY_FEEDBACK__DigitalOutput__, OCCUPANCY_FEEDBACK );
    
    VACANCY_TRIGGER = new Crestron.Logos.SplusObjects.DigitalOutput( VACANCY_TRIGGER__DigitalOutput__, this );
    m_DigitalOutputList.Add( VACANCY_TRIGGER__DigitalOutput__, VACANCY_TRIGGER );
    
    VACANCY_FEEDBACK = new Crestron.Logos.SplusObjects.DigitalOutput( VACANCY_FEEDBACK__DigitalOutput__, this );
    m_DigitalOutputList.Add( VACANCY_FEEDBACK__DigitalOutput__, VACANCY_FEEDBACK );
    
    OCCUPANCY_RAW = new Crestron.Logos.SplusObjects.DigitalOutput( OCCUPANCY_RAW__DigitalOutput__, this );
    m_DigitalOutputList.Add( OCCUPANCY_RAW__DigitalOutput__, OCCUPANCY_RAW );
    
    VACANCY_RAW = new Crestron.Logos.SplusObjects.DigitalOutput( VACANCY_RAW__DigitalOutput__, this );
    m_DigitalOutputList.Add( VACANCY_RAW__DigitalOutput__, VACANCY_RAW );
    
    SENSOR_TIMEOUT = new Crestron.Logos.SplusObjects.AnalogInput( SENSOR_TIMEOUT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SENSOR_TIMEOUT__AnalogSerialInput__, SENSOR_TIMEOUT );
    
    
    ENABLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENABLE_OnPush_0, false ) );
    DISABLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( DISABLE_OnPush_1, false ) );
    SENSOR_INPUT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SENSOR_INPUT_OnPush_2, false ) );
    SENSOR_INPUT.OnDigitalRelease.Add( new InputChangeHandlerWrapper( SENSOR_INPUT_OnRelease_3, false ) );
    FORCE_OCCUPANCY.OnDigitalPush.Add( new InputChangeHandlerWrapper( FORCE_OCCUPANCY_OnPush_4, false ) );
    FORCE_VACANCY.OnDigitalPush.Add( new InputChangeHandlerWrapper( FORCE_VACANCY_OnPush_5, false ) );
    SENSOR_TIMEOUT.OnAnalogChange.Add( new InputChangeHandlerWrapper( SENSOR_TIMEOUT_OnChange_6, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_OCCUPANCY_SENSOR_V2_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SENSOR_OPENS_ON_MOTION__DigitalInput__ = 0;
const uint ENABLE__DigitalInput__ = 1;
const uint DISABLE__DigitalInput__ = 2;
const uint SENSOR_INPUT__DigitalInput__ = 3;
const uint FORCE_OCCUPANCY__DigitalInput__ = 4;
const uint FORCE_VACANCY__DigitalInput__ = 5;
const uint SENSOR_TIMEOUT__AnalogSerialInput__ = 0;
const uint ENABLED__DigitalOutput__ = 0;
const uint DISABLED__DigitalOutput__ = 1;
const uint OCCUPANCY_TRIGGER__DigitalOutput__ = 2;
const uint OCCUPANCY_FEEDBACK__DigitalOutput__ = 3;
const uint VACANCY_TRIGGER__DigitalOutput__ = 4;
const uint VACANCY_FEEDBACK__DigitalOutput__ = 5;
const uint OCCUPANCY_RAW__DigitalOutput__ = 6;
const uint VACANCY_RAW__DigitalOutput__ = 7;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort SENSOR_TYPE = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort TIMER_RUNNING = 0;
            [SplusStructAttribute(2, false, true)]
            public ushort IN_FORCE_VACANCY = 0;
            [SplusStructAttribute(3, false, true)]
            public ushort IN_FORCE_OCCUPANCY = 0;
            [SplusStructAttribute(4, false, true)]
            public uint TIMER = 0;
            
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
