using UnityEngine;

public class BallTracking : MonoBehaviour
{
    [SerializeField] private Vector3 _directionOffset;
    [SerializeField] private float _length;

    private Ball _ball;
    private Beam _beam;
    private Vector3 _cameraPosition;
    private Vector3 _minimumBallPosition;

    private void Start()
    {
        _ball = FindObjectOfType<Ball>();                  
        _beam = FindObjectOfType<Beam>();                  

        _cameraPosition = _ball.transform.position;             
        _minimumBallPosition = _ball.transform.position;       

        TrackBall();
    }

    private void Update()
    {
        if (_ball.transform.position.y < _minimumBallPosition.y)               
        {
            TrackBall();
            _minimumBallPosition = _ball.transform.position;                  
        }
    }

    private void TrackBall()
    {
        Vector3 BeamPosition = _beam.transform.position;
        BeamPosition.y = _ball.transform.position.y;                                           
        _cameraPosition = _ball.transform.position;
        Vector3 direction = (BeamPosition - _ball.transform.position).normalized + _directionOffset;                     

        _cameraPosition -= direction * _length;       
        transform.position = _cameraPosition;           
        transform.LookAt(_ball.transform);      
    }
}
