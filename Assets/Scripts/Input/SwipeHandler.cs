using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts
{
    public class SwipeHandler : MonoBehaviour
    {
        public delegate void SwipeUpMethod();
        public delegate void SwipeDownMethod();
        public delegate void SwipeLeftMethod();
        public delegate void SwipeRightMethod();
        public event SwipeUpMethod OnSwipeUp;
        public event SwipeDownMethod OnSwipeDown;
        public event SwipeLeftMethod OnSwipeLeft;
        public event SwipeRightMethod OnSwipeRight;


        [SerializeField] [Range(0, 1)] private float _deadzone;
        [SerializeField] [Range(0, 1)] private float _directionThreshold;

        private PlayerControls _playerControls;
        private Vector2 _startPosition;
        private Vector2 _endPosition;

        private void OnEnable()
        {
            _playerControls = new PlayerControls();
            _playerControls.Enable();
            _playerControls.Swipe.OnTouch.started += callbackContext => StartSwipe();
            _playerControls.Swipe.OnTouch.canceled += callbackContext => EndSwipe();
        }

        private void StartSwipe() => _startPosition = _playerControls.Swipe.StartTouch.ReadValue<Vector2>();

        private void EndSwipe()
        {
            _endPosition = _playerControls.Swipe.Position.ReadValue<Vector2>();
            Vector2 direction = (_endPosition - _startPosition).normalized;

            if (direction.magnitude > _deadzone)
            {
                DeterminateSwipeDirection(direction);
            }

            Reset();
        }

        private void Reset()
        {
            _startPosition = _endPosition = Vector2.zero;
        }

        private void DeterminateSwipeDirection(Vector2 direction)
        {
            if (Vector2.Dot(Vector2.up, direction) > _directionThreshold) OnSwipeUp?.Invoke();

            if (Vector2.Dot(Vector2.down, direction) > _directionThreshold) OnSwipeDown?.Invoke();

            if (Vector2.Dot(Vector2.left, direction) > _directionThreshold) OnSwipeLeft?.Invoke();

            if (Vector2.Dot(Vector2.right, direction) > _directionThreshold) OnSwipeRight?.Invoke();
        }

        private void OnDisable()
        {
            _playerControls.Disable();
        }
    }
}