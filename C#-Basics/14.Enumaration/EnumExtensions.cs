using System;

namespace EnumDemo;

public enum TrafficLight
{
    Red,
    Yellow,
    Green
}

// 1. EXTENSION CLASS
// Must be static!
public static class TrafficLightExtensions
{
    // 2. EXTENSION METHOD
    // The 'this' keyword attaches this method to the TrafficLight Enum!
    public static string GetDrivingInstruction(this TrafficLight light)
    {
        if (light == TrafficLight.Red)
        {
            return "STOP! The light is Red.";
        }
        else if (light == TrafficLight.Green)
        {
            return "GO! The light is Green.";
        }
        else
        {
            return "SLOW DOWN! The light is Yellow.";
        }
    }
}