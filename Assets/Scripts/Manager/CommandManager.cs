using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager : MonoBehaviour
{
    // this is going to be a singleton
    private static CommandManager _instance;

    public static CommandManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("CommandManager is null.");

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    private List<ICommand> _commandBuffer = new List<ICommand>();

    public void AddCommand(ICommand command)
    {
        _commandBuffer.Add(command);
    }

    public void Play()
    {
        StartCoroutine(PlayRoutine());
    }

    public IEnumerator PlayRoutine()
    {
        foreach (var c in _commandBuffer)
        {
            c.Execute();
            yield return new WaitForEndOfFrame();
        }
    }

    public void Reverse()
    {
        StartCoroutine(ReverseRoutine());
    }

    public IEnumerator ReverseRoutine()
    {
        foreach (var c in Enumerable.Reverse(_commandBuffer))
        {
            c.Undo();
            yield return new WaitForEndOfFrame();
        }
    }

}
