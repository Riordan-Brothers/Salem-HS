namespace GLPP_Helper;
        // class declarations
         class GLPPEventArgs;
         class GLPPFileOps;
         class XML_Helper;
         class GLPPEvents;
         class GLPPSettingsClass;
     class GLPPEventArgs 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING glppID[];
        GLPPSettingsClass glppSettings;
    };

    static class GLPPFileOps 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION parseXML ( STRING FileName );
        static INTEGER_FUNCTION saveSettings ( STRING glppID );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class XML_Helper 
    {
        // class delegates

        // class events
        EventHandler OnDataChange ( XML_Helper sender, GLPPEventArgs e );

        // class functions
        FUNCTION Initialize ( STRING glppID );
        INTEGER_FUNCTION updateXML ();
        FUNCTION setName ( STRING newName );
        FUNCTION setZoneName ( INTEGER index , STRING newName );
        FUNCTION setLocalMotion ( INTEGER newMotion );
        FUNCTION setTimeout ( INTEGER newTimeout );
        FUNCTION setOccupancyAction ( INTEGER newAction );
        FUNCTION setVacatingAction ( INTEGER newAction );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        STRING glppID[];
        GLPPSettingsClass myGLPP;

        // class properties
    };

     class GLPPEvents 
    {
        // class delegates

        // class events
        EventHandler OnDataChange ( GLPPEvents sender, GLPPEventArgs e );

        // class functions
        FUNCTION FireDataChange ( GLPPEventArgs e );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class GLPPSettingsClass 
    {
        // class delegates

        // class events

        // class functions
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DefeatLocalMotion;
        INTEGER SetTimeout;
        INTEGER OccupancyAction;
        INTEGER VacatingAction;
        INTEGER NumZones;
        STRING RoomName[];
        STRING ZoneNames[][];
    };

