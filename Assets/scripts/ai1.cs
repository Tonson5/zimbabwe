using UnityEngine;
using UnityEngine.AI;
using System.Collections;
public class ai1 : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject target;
    public float wanderRadius;
    public float wanderDistance;
    public float wanderJitter;
    public Vector3 WanderTarget = Vector3.zero;
    public bool attacking;
    public float viewDistance;
    public float attackRange;
    public GameObject bullet;
    public bool seeker = true;
    public GameObject bus;
    RaycastHit hit;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if(Random.Range(0,4) == 1)
            seeker = false;
        bus = GameObject.Find("bus");
    }
    void Seek(Vector3 location)
    {
        agent.SetDestination(location);
    }
    void Wander()
    {
        WanderTarget += new Vector3(transform.position.x + Random.Range(-1.0f, 1.0f) * wanderJitter, 0, transform.position.z + Random.Range(-1.0f, 1.0f) * wanderJitter);
        WanderTarget.Normalize();
        WanderTarget *= wanderRadius;

        Vector3 targetLocal = WanderTarget + new Vector3(0, 0, wanderDistance);
        Vector3 targetWorld = transform.InverseTransformVector(targetLocal);
        Seek(targetWorld);
        if (Physics.Raycast(transform.position, transform.forward, out hit, viewDistance * 2f) == true && hit.collider.gameObject.CompareTag("Player"))
        {

            attacking = true;
            target = hit.collider.gameObject;
        }
        Debug.DrawRay(transform.position, transform.forward * viewDistance * 2f, Color.blue, 0.1f);
        if (Physics.Raycast(transform.position, transform.forward + -transform.right, out hit, viewDistance) == true && hit.collider.gameObject.CompareTag("Player"))
        {
            attacking = true;
            target = hit.collider.gameObject;
        }
        Debug.DrawRay(transform.position, transform.forward + -transform.right * viewDistance, Color.blue, 0.1f);
        if (Physics.Raycast(transform.position, transform.forward + transform.right, out hit, viewDistance) == true && hit.collider.gameObject.CompareTag("Player"))
        {
            attacking = true;
            target = hit.collider.gameObject;
        }
        Debug.DrawRay(transform.position, transform.forward + transform.right * viewDistance, Color.blue, 0.1f);

        if (hit.collider != null)
        {
            Debug.Log(hit.collider);
        }

    }
    public bool shootable;
    void Update()
    {
        if (attacking)
        {
            if (target == null)
            {
                attacking = false;
            }
            else
            {
                Seek(target.transform.position);
            }
            if (((target.transform.position - transform.position).magnitude < attackRange && target != null))
            {
                if (attacking && shootable)
                {
                    transform.LookAt(target.transform.position);

                    StartCoroutine(Shoot());
                }

            }
            



        }
        else
        {
            if (seeker)
            {
                Seek(bus.transform.position);
                if (Physics.Raycast(transform.position, transform.forward, out hit, viewDistance * 2f) == true && hit.collider.gameObject.CompareTag("Player"))
                {

                    attacking = true;
                    target = hit.collider.gameObject;
                }
                Debug.DrawRay(transform.position, transform.forward * viewDistance * 2f, Color.blue, 0.1f);
                if (Physics.Raycast(transform.position, transform.forward + -transform.right, out hit, viewDistance) == true && hit.collider.gameObject.CompareTag("Player"))
                {
                    attacking = true;
                    target = hit.collider.gameObject;
                }
                Debug.DrawRay(transform.position, transform.forward + -transform.right * viewDistance, Color.blue, 0.1f);
                if (Physics.Raycast(transform.position, transform.forward + transform.right, out hit, viewDistance) == true && hit.collider.gameObject.CompareTag("Player"))
                {
                    attacking = true;
                    target = hit.collider.gameObject;
                }
                Debug.DrawRay(transform.position, transform.forward + transform.right * viewDistance, Color.blue, 0.1f);
                if ((bus.transform.position - transform.position).magnitude < attackRange)
                {
                    if (shootable)
                    {
                        transform.LookAt(bus.transform.position);

                        StartCoroutine(Shoot());
                    }
                }
            }
            else
                Wander();
        }

    }
    IEnumerator Shoot()
    {
        shootable = false;
        yield return new WaitForSeconds(Random.Range(0,0.5f));
        Instantiate(bullet, transform.position + transform.forward / 2, transform.rotation);
        yield return new WaitForSeconds(Random.Range(0.1f, 1f));
        shootable = true;
    }
}
