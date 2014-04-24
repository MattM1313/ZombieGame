using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{

    class KDNode {

        public GameObject value;
        public KDNode left;
        public KDNode right;

        public KDNode(GameObject value) {
            this.value = value;
            left = null;
            right = null;
        }
    }

    class KDTree {
        private KDNode root;
        private int depth;

        public KDTree() {
            this.depth = 2;
            root = null;
        }
        public KDTree(GameObject root) {
            this.depth = 2;
            Push(root);
        }
        public KDTree(KDTree oldTree) {
            this.depth = 2;
            Push(oldTree.GetAllValues());
        }
        public KDTree(List<GameObject> values) {
            this.depth = 2;
            Push(values);
        }

        public void Push(List<GameObject> values) {
            foreach(GameObject boid in values) {
                Push(boid);
            }
        }
        public int Push(GameObject value) {
            KDNode pushedNode = new KDNode(value);

            if(value == null) {
                return -1;
            } else if (root == null) {
                root = new KDNode(value);
                return 1;
            }

            KDNode currentNode = root;
            KDNode parentNode = root;
            float[] newCoord = new float[] { value.transform.position.x, value.transform.position.y };
            int level = 0;

            while(true) {
                parentNode = currentNode;
                float[] currentCoord = new float[] { currentNode.value.transform.position.x, currentNode.value.transform.position.y };

                if(newCoord[level] < currentCoord[level]) {
                    currentNode = currentNode.left;

                    if(currentNode == null) {
                        parentNode.left = pushedNode;
                        return 1;
                    }
                } else {
                    currentNode = currentNode.right;

                    if(currentNode == null) {
                        parentNode.right = pushedNode;
                        return 1;
                    }
                }

                level = ++level % depth;
            }
        }

        public List<GameObject> GetInRadius(GameObject boid, float radius) {
            List<GameObject> list = new List<GameObject>();
            
            GetInRadius(root, boid, radius, list);

            return list;
        }
        private void GetInRadius(KDNode node, GameObject boid, float radius, List<GameObject> list) {
            radius = Mathf.Abs(radius);

            float distance = (new Vector3(node.value.transform.position.x, node.value.transform.position.y) - boid.transform.position).magnitude;

            if(node.value != boid && distance < radius) {
                list.Add(node.value);
            }

            if(node.left != null) {
                GetInRadius(node.left, boid, radius, list);
            }
            if(node.right != null) {
                GetInRadius(node.right, boid, radius, list);
            }
        }

        public List<GameObject> GetOutsideRadius(GameObject boid, float radius) {
            List<GameObject> list = new List<GameObject>();
            radius = Mathf.Abs(radius);

            float[] min = { boid.transform.position.x - radius, boid.transform.position.y - radius };
            float[] max = { boid.transform.position.x + radius, boid.transform.position.y + radius };

            int level = 0;

            GetOutsideRadius(root, boid, radius, min , max, list, level);

            return list;
        }
        public void GetOutsideRadius(KDNode node, GameObject boid, float radius, float[] min, float[] max, List<GameObject> list, int level) {

            float distance = (new Vector3(node.value.transform.position.x, node.value.transform.position.y) - boid.transform.position).magnitude;
            float[] currPos = { node.value.transform.position.x, node.value.transform.position.y };

            if(node.value != boid && distance > radius) {
                list.Add(node.value);
            }

            if(node.left != null && min[level] < currPos[level]) {
                GetOutsideRadius(node.left, boid, radius, min, max, list, (level + 1) % depth);
            }
            if(node.right != null && max[level] >= currPos[level]) {
                GetOutsideRadius(node.right, boid, radius, min, max, list, (level + 1) % depth);
            }
        }

        public List<GameObject> GetAllValues() {
            List<GameObject> list = new List<GameObject>();

            GetAllNodes(root, list);

            return list;
        }
        public void GetAllNodes(KDNode node, List<GameObject> list) {
            list.Add(node.value);

            if(node.left != null) {
                GetAllNodes(node.left, list);
            }
            if(node.right != null) {
                GetAllNodes(node.right, list);
            }
        }
    }
}
