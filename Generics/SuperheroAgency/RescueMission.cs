﻿namespace SuperheroAgency;

public class RescueMission<T> : Mission<T>
{
    public RescueMission(string location, int reward, int difficulty) : base(location, reward, difficulty)
    {
    }
}
