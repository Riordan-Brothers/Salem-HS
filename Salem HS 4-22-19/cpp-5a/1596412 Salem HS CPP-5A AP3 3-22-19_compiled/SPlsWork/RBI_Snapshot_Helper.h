namespace RBI_Snapshot_Helper;
        // class declarations
         class Snapshot_Helper;
     class Snapshot_Helper 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION InitialInit ( INTEGER Days , INTEGER Multiples , STRING Location );
        FUNCTION NightlyUpdate ( INTEGER OccStatus[] );
        STRING_FUNCTION ToString ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

