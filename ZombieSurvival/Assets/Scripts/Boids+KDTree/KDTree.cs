//using UnityEngine;
//using System.Collections;
//public class Node {
//	public GameObject key;
//	public Node left;
//	public Node right;
//	public Node(GameObject val)
//	{
//		key = val;
//		left = null;
//		right = null;
//	}
//
//}
//public class KDTree{
//
//	private Node root;
//	private int depth;
//
//	public KDTree(int depth){
//		this.depth = depth;
//		root = null;
//
//
//	}
//
//	public void Push(GameObject key)
//	{
//		Node newNode = new Node(key);
//
//		if(root == null)
//		{
//			root = newNode;
//			return;
//		}
//
//		Node currNode = root;
//		Node parentNode = root;
//		int level = 0;
//
//		//traverse
//		while(true)
//		{
//			parentNode = currNode;
//
//			if(level == 0)
//			{
//				if(key.transform.position.x <= currNode.key.transform)
//				{
//					currNode = currNode.left;
//					if(currNode == null)
//					{
//						parentNode.left = newNode;
//						return;
//					}
//				}
//				else{
//					currNode = currNode.right;
//					if(currNode == null)
//					{
//						parentNode.right = newNode;
//						return;
//					}
//				}
//
//				++level;
//
//				if(level >= this.depth)
//					level = 0;
//			}
//
//			if(level = 1)
//			{
//				if(key.transform.position.y <= currNode.key.transform)
//				{
//					currNode = currNode.left;
//					if(currNode == null)
//					{
//						parentNode.left = newNode;
//						return;
//					}
//				}
//				else{
//					currNode = currNode.right;
//					if(currNode == null)
//					{
//						parentNode.right = newNode;
//						return;
//					}
//				}
//				
//				++level;
//				
//				if(level >= this.depth)
//					level = 1;
//			}
//
//			if(level = 2)
//			{
//				if(key.transform.position.z <= currNode.key.transform)
//				{
//					currNode = currNode.left;
//					if(currNode == null)
//					{
//						parentNode.left = newNode;
//						return;
//					}
//				}
//				else{
//					currNode = currNode.right;
//					if(currNode == null)
//					{
//						parentNode.right = newNode;
//						return;
//					}
//				}
//				
//				++level;
//				
//				if(level >= this.depth)
//					level = 2;
//			}
//
//		}
//
//
//
//
//
//
//
//	}
//
//
//
//}
