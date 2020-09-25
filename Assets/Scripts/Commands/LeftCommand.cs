using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCommand : ICommand
{
    // what do I need from the player to execute the command?
    private Transform _player;
    private float _playerSpeed;
    private Vector3 leftVector = Vector3.left;

    public LeftCommand(Transform player, float speed)
    {
        this._player = player;
        this._playerSpeed = speed;
    }

    public void Execute()
    {
        _player.Translate(leftVector * _playerSpeed * Time.deltaTime);
    }

    public void Undo()
    {
        _player.Translate(Vector3.right * _playerSpeed * Time.deltaTime);

    }
}
