using System.Collections;using System.Collections.Generic;using System.Linq;using System;
using UnityEngine;


/// <summary>
/// functions to implement the "blizards" (objects that "block" certain tiles from being passable creating "choke points" and "corners")
/// </summary>
public partial class RiskySandBox_BlizardFunctions : MonoBehaviour
{

    //=====================================================================credits======================================================================================================================================

    //if you want to put your name in here you will be automatically be added to the "credits" of the of the game once i have implemented this (see main menu -> credits) 
    //remember to put ""  in any unneeded links
    public static List<string> credits = new List<string>// put your name here...
    {

    };

    public static List<string> credits_discord = new List<string>
    {

    };

    public static List<string> credits_reddit = new List<string>
    {

    };

    public static List<string> credits_twitch_channel = new List<string>
    {

    };

    public static List<string> credits_twitter = new List<string>
    {

    };

    public static List<string> credits_youtube_channel_ID = new List<string>    //  www.youtube.com/@       (only include the bit after the "@")
    {

    };

    //public static List<string> credits_website = new List<string> { };  //hmmm probably wont implement this...


    //==================================================================================================================================================================================================================






    /// <summary>
    /// create the blizards for the start of the game
    /// </summary>
    public static List<int> selectStartOfGameBlizard(Dictionary<int,List<int>> _graph, int _target_n_blizards)
    {
        List<int> _blizards = new List<int>();

        //go through the graph...
        //select the tiles that should become blizards...




        return _blizards;
    }



    /// <summary>
    /// returns a list of all the tiles that can become blizards
    /// </summary>
    public static List<int> GET_blizardCandidates(Dictionary<int,List<int>> _graph)
    {
        List<int> _blizard_candidates = new List<int>();

        //look at the graph....
        //detemine which tiles could become blizards....






        //randomly select _n_blizards (from the candidates)
        return null;
    }


    /// <summary>
    /// return true if the tile can become a blizard...
    /// </summary>
    public static bool canBecomeBlizard(Dictionary<int,List<int>> _graph, int _tile_ID)
    {
        //decide if _tile_ID can become a blizard   (this MIGHT be a powerup in the shop at some point (e.g. ice bomb) which will create a temporary? blizard
        //in order to do this there must be a way to determine if the tile can become a blizard...



        return false;
    }






}
