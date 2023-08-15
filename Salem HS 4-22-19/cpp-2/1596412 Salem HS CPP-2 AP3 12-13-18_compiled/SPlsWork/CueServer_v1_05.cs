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

namespace UserModule_CUESERVER_V1_05
{
    public class UserModuleClass_CUESERVER_V1_05 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.StringInput TO_CUESERVER__DOLLAR__;
        SplusTcpClient CUESERVER;
        StringParameter IP_ADDRESS;
        CrestronString G_SINCOMMAND;
        CrestronString G_SOUTCOMMAND;
        private void DOCUESERVERCONNECT (  SplusExecutionContext __context__ ) 
            { 
            ushort SIERR = 0;
            
            
            __context__.SourceCodeLine = 35;
            SIERR = (ushort) ( Functions.SocketConnectClient( CUESERVER , IP_ADDRESS  , (ushort)( 80 ) , (ushort)( 0 ) ) ) ; 
            __context__.SourceCodeLine = 36;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIERR < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 36;
                Print( "Connection Error: {0:d}\r\n", (short)SIERR) ; 
                }
            
            
            }
            
        private void DOREFORMATCOMMANDSTRING (  SplusExecutionContext __context__ ) 
            { 
            CrestronString SREMOVE;
            SREMOVE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            CrestronString SPLUSREMOVE;
            SPLUSREMOVE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            CrestronString SREPLACE;
            SREPLACE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            
            __context__.SourceCodeLine = 45;
            if ( Functions.TestForTrue  ( ( Functions.Find( "+" , G_SINCOMMAND ))  ) ) 
                { 
                __context__.SourceCodeLine = 47;
                while ( Functions.TestForTrue  ( ( Functions.Find( "+" , G_SINCOMMAND ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 49;
                    SREMOVE  .UpdateValue ( Functions.Remove ( "+" , G_SINCOMMAND )  ) ; 
                    __context__.SourceCodeLine = 50;
                    SPLUSREMOVE  .UpdateValue ( Functions.Remove ( (Functions.Length( SREMOVE ) - 1), SREMOVE )  ) ; 
                    __context__.SourceCodeLine = 51;
                    G_SINCOMMAND  .UpdateValue ( SPLUSREMOVE + "%2B" + G_SINCOMMAND  ) ; 
                    __context__.SourceCodeLine = 47;
                    } 
                
                } 
            
            __context__.SourceCodeLine = 55;
            G_SOUTCOMMAND  .UpdateValue ( G_SINCOMMAND  ) ; 
            __context__.SourceCodeLine = 57;
            DOCUESERVERCONNECT (  __context__  ) ; 
            
            }
            
        object TO_CUESERVER__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 63;
                if ( Functions.TestForTrue  ( ( Functions.Find( "\u000D" , TO_CUESERVER__DOLLAR__ ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 66;
                    G_SINCOMMAND  .UpdateValue ( TO_CUESERVER__DOLLAR__  ) ; 
                    __context__.SourceCodeLine = 67;
                    Functions.ClearBuffer ( TO_CUESERVER__DOLLAR__ ) ; 
                    __context__.SourceCodeLine = 69;
                    DOREFORMATCOMMANDSTRING (  __context__  ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object CUESERVER_OnSocketConnect_1 ( Object __Info__ )
    
        { 
        SocketEventInfo __SocketInfo__ = (SocketEventInfo)__Info__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SocketInfo__);
            short SIERR = 0;
            
            CrestronString SCOMMAND;
            SCOMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
            
            
            __context__.SourceCodeLine = 79;
            MakeString ( SCOMMAND , "GET /exe.cgi?cmd={0} HTTP/1.1\r\n\r\n", G_SOUTCOMMAND ) ; 
            __context__.SourceCodeLine = 80;
            G_SOUTCOMMAND  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 83;
            SIERR = (short) ( Functions.SocketSend( CUESERVER , SCOMMAND ) ) ; 
            __context__.SourceCodeLine = 84;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SIERR < 0 ))  ) ) 
                {
                __context__.SourceCodeLine = 84;
                Print( "Send Error: {0:d}\r\n", (short)SIERR) ; 
                }
            
            __context__.SourceCodeLine = 87;
            Functions.SocketDisconnectClient ( CUESERVER ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SocketInfo__ ); }
        return this;
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    G_SINCOMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
    G_SOUTCOMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5000, this );
    CUESERVER  = new SplusTcpClient ( 5000, this );
    
    TO_CUESERVER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( TO_CUESERVER__DOLLAR____AnalogSerialInput__, 5000, this );
    m_StringInputList.Add( TO_CUESERVER__DOLLAR____AnalogSerialInput__, TO_CUESERVER__DOLLAR__ );
    
    IP_ADDRESS = new StringParameter( IP_ADDRESS__Parameter__, this );
    m_ParameterList.Add( IP_ADDRESS__Parameter__, IP_ADDRESS );
    
    
    TO_CUESERVER__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( TO_CUESERVER__DOLLAR___OnChange_0, false ) );
    CUESERVER.OnSocketConnect.Add( new SocketHandlerWrapper( CUESERVER_OnSocketConnect_1, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CUESERVER_V1_05 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint TO_CUESERVER__DOLLAR____AnalogSerialInput__ = 0;
const uint IP_ADDRESS__Parameter__ = 10;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
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
