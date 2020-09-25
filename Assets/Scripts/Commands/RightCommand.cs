using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCommand : ICommand
{
    // what do I need from the player to execute the command?
    private Transform _player;
    private float _playerSpeed;
    private Vector3 rightVector = Vector3.right;

    public RightCommand(Transform player, float speed)
    {
        this._player = player;
        this._playerSpeed = speed;
    }

    public void Execute()
    {
        _player.Translate(rightVector * _playerSpeed * Time.deltaTime);
    }

    public void Undo()
    {
        _player.Translate(Vector3.left * _playerSpeed * Time.deltaTime);
    }
}
