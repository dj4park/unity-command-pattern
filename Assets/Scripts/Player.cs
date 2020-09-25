using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ICommand command = new UpCommand(this.transform, this._speed);
            command.Execute();
            CommandManager.Instance.AddCommand(command);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            ICommand command = new DownCommand(this.transform, this._speed);
            command.Execute();
            CommandManager.Instance.AddCommand(command);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            ICommand command = new RightCommand(this.transform, this._speed);
            command.Execute();
            CommandManager.Instance.AddCommand(command);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            ICommand command = new LeftCommand(this.transform, this._speed);
            command.Execute();
            CommandManager.Instance.AddCommand(command);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            CommandManager.Instance.Reverse();
        }
    }
}
