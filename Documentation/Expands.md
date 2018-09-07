# Expands
## What are expands
Expands are used to gather more data than the initial object you have requested: Lets say you want to get all events from a tournament but also the tournaments information.
Adding expand[]=event will include the events with the tournament in your request.

## How do I add them to my request
To add an expand to your request simply add ?expand[]=*<expand item>* to your request. You can also add multiple expands by using an '&' sign.
For example: "http://api.smash.gg/v1/tournament/smash-summit-6?expand[]=event&expand[]=group"

**You can not use expand[]=event&group**

## Is it safe to always add expands?
Yes it is! smash.gg has made it in their API that expands are always accepted and will not fail a request based on it.
If you were to expand events on an event request it would simply return the event in question and ignore your expand.

This is also true for the SmashggNet wrapper.

## Expands in the SmashggNet wrapper
Expands are done using a list that you give with each request. The list can contain any number of expands and it will be added to the result for you.
If an expand property is not selected it will just be null.

All methods calls that support expands will have documentation that explains which expands can be used in that request. Adding more isn't harmful but can hurt performance.
