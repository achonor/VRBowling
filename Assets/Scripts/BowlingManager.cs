using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingManager : SingleInstance<BowlingManager>
{
    [SerializeField]
    private Animator mAnimator;
    [SerializeField]
    private List<Transform> mBalls;

    private List<Vector3> mBallsInitPos = new List<Vector3>();

    private void Start() {
        for (int i = 0; i < mBalls.Count; i++) {
            mBallsInitPos.Add(mBalls[i].localPosition);
        }   
    }

    public void ResetAllBall() {
        StartCoroutine(_ResetAllBall());
    }

    private IEnumerator _ResetAllBall() {
        yield return null;
        for (int i = 0; i < mBalls.Count; i++) {
            mBalls[i].localPosition = mBallsInitPos[i];
            Rigidbody rigidbody = mBalls[i].GetComponent<Rigidbody>();
            rigidbody.isKinematic = true;
            yield return null;
            rigidbody.isKinematic = false;
        }
    }

    public void PlayBowlingUp() {
        mAnimator?.Play("Bottles_Up");
    }

    public void PlayBowlingDown() {
        mAnimator?.Play("Bottles_Down");
    }
}
