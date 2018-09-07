This file will contain a list of endpoints know with what calls they support.
***THERE ARE ONLY GET CALLS IN THE SMASH.GG API***

# Tournaments
**tournament/<tournamentName>** name should be passed with spaces switch with '-'

**tournament/<tournamentName>/event/<eventName>** Gets the event based on tournament and event name
# Events
**event/<eventId>** Gets an event based on it's ID

**tournament/<tournamentName>/event/<eventName>** Gets the event based on tournament and event name

# Phase Groups (brackets)
**phase_group/<phaseGroupId>** Gets a phase group based on its id.
**tournament/<tournamentName>/events/<eventName><bracketId><phaseGroupId>** WIP
