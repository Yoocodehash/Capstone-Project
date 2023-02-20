using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Apple;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class FireBall : MonoBehaviour
{
   public Transform projectilePoint;
   public GameObject fireballprefab;
   public float fireballspeed = 10;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var magic = Instantiate(fireballprefab, projectilePoint.position, projectilePoint.rotation);
            magic.GetComponent<Rigidbody>().velocity = projectilePoint.forward * fireballspeed;

        }
    }

    /*
    public Camera cam;
    public GameObject projectile;
    public Transform RHFirePoint;
    public float projectileSpeed = 30;
    public float fireRate = 4;

    private Vector3 destination;
    private bool rightHand;
    private float timeToFire;

    PlayerInput playerInput;
    CharacterController characterController;
    Animator animator;
    int isAttackHash;
    bool isAttackPressed;

    // Awake is called earlier than Start in Unity's event life cycle
    void Awake()
    {
        playerInput = new PlayerInput();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        isAttackHash = Animator.StringToHash("isAttack");

        playerInput.CharacterControls.Run.started += onAttack;
        playerInput.CharacterControls.Run.canceled += onAttack;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= timeToFire)
        {
            timeToFire = Time.time + 1 / fireRate; 
            ShootProjectile();
        }


    }

    void ShootProjectile()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
       // isMouseClick = Input.GetButtonDown("Fire1");
        bool isAttack = animator.GetBool(isAttackHash);

        if (Physics.Raycast(ray, out hit))
            destination = hit.point;
        else
            destination = ray.GetPoint(1000);

        if (isAttackPressed && !isAttack)
        {
            animator.SetBool(isAttackHash, true);
        }
        else if (!isAttackPressed && isAttack)
        {
            animator.SetBool(isAttackHash, false);
        }

        if (rightHand)
        {
            rightHand = false;
            InstantiateProjectile(RHFirePoint);
        }
        else
        {
            rightHand = true;
          //  InstantiateProjectile(RHFirePoint);
        }

    }


    void onAttack(InputAction.CallbackContext context)
    {
        isAttackPressed = context.ReadValueAsButton();
    }

    void InstantiateProjectile(Transform firePoint)
    {
        var projectileObj = Instantiate(projectile, firePoint.position, Quaternion.identity) as GameObject;
        projectileObj.GetComponent<Rigidbody>().velocity = (destination - firePoint.position).normalized * projectileSpeed;
    }
    */
}
