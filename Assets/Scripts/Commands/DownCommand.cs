using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCommand : ICommand
{
    // what do I need from the player to execute the command?
    private Transform _player;
    private float _playerSpeed;
    private Vector3 downVector = Vector3.down;

    public DownCommand(Transform player, float speed)
    {
        this._player = player;
        this._playerSpeed = speed;
    }

    public void Execute()
    {
        _player.Translate(downVector * _playerSpeed * Time.deltaTime);
    }

    public void Undo()
    {
        _player.Translate(Vector3.up * _playerSpeed * Time.deltaTime);
    }
}
