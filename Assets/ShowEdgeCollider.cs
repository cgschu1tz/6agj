using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class ShowEdgeCollider : MonoBehaviour
{
	private EdgeCollider2D _edgeCollider;
	private Vector2[] _points;
	private Vector3 _t;

	void Start()
	{
		_edgeCollider = GetComponent<EdgeCollider2D>();
		_points = _edgeCollider.points;
		_t = _edgeCollider.transform.position;
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		for (int i = 0; i < _points.Length - 1; i++)
		{
			Gizmos.DrawLine(new Vector3(_points[i].x + _t.x, _points[i].y + _t.y), new Vector3(_points[i + 1].x + _t.x, _points[i + 1].y + _t.y));
		}
	}

}