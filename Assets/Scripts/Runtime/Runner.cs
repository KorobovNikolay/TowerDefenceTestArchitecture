using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Runtime
{
    public class Runner : MonoBehaviour
    {
        private List<IController> _controllers;
        private bool _isRunning = false;

        public void StartRunning()
        {
            OnStartControllers();
            _isRunning = true;
        }

        public void StopRunning()
        {
            OnStopControllers();
            _isRunning = false;
        }

        private void Update()
        {
            if(_isRunning) TickControllers();
        }

        private void CreateAllControllers()
        {
            _controllers = new List<IController>();
        }

        private void OnStartControllers()
        {
            foreach (var controller in _controllers)
                controller?.OnStart();
        }

        private void TickControllers()
        {
            foreach (var controller in _controllers)
                controller?.Tick();
        }

        private void OnStopControllers()
        {
            foreach (var controller in _controllers)
                controller?.OnStop();
        }


    }
}
