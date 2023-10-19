using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input
{
    private static PlayerControls _playerControls;
    // Start is called before the first frame update
    public static void Initialize(Player _player)
    {
        _playerControls = new PlayerControls();

        _playerControls.Player.Movement.performed += w =>
        {
            _player.SetMoveDirection(w.ReadValue<Vector3>());
        };

    }

    public static void SetPlayerControls()
    {
        _playerControls.Player.Enable();
    }
}
