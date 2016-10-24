# Pokemon_Type_Calculator
A tool to help trainers find type matchings/dual types/team compositions.

Completed:

    Defensive dual type calculator                                              [done]
    Offensive dual type calculator                                              [done]

Needs improving:

    Offensive score needs more meaning                                          [C#]
    UI (I don't know good UI)                                                   [C#]
    Notes for Furter implementation                                             [text]

Needs to be done:

    Form + functionality for:
        Two pokemon's type coverage + score                                     [C#]
        Raw Type Table                                                          [C#]
        Every type combo output at once                                         [C#]
        
    Functionality for:
        Calculating pokemon stats at each level/ev/iv                           [C#]
        
    A DB or class file with all pokemon                                         [A DB or sheet compatible with C#]
        Needs to have:
            Name                                                                  
            Types
                If single type, the second type has to be set to "Null"
                different types across different region if applicable
            Base stats
            Move list
            Also based on region
                the 'first' move set should be the most currrent
                the others named based on what gen that moveset is from
                this can be left out, depends on who does it
             Locationas across different regions
        Is either a C# class file or a DB easily read by C# 
        Is correct (duh)

Road Map:

    All pokemon added (in project or in DB)
    Will claculate a team based on users prefrences
    Type analysis
    Pokemon analysis
    Pokemon Maps with locations overlayed
