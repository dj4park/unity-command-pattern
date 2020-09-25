using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCommand : ICommand
{
    // what do I need from the player to execute the command?
    private Transform _player;
    private float _playerSpeed;
    private Vector3 upVector = Vector3.up;

    public UpCommand(Transform player, float speed)
    {
        this._player = player;
        this._playerSpeed = speed;
    }

    public void Execute()
    {
        _player.Translate(upVector * _playerSpeed * Time.deltaTime);
    }

    public void Undo()
    {
        _player.Translate(Vector3.down * _playerSpeed * Time.deltaTime);
    }
}
