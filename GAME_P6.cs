void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Basket"))
    {
        FindObjectOfType<GameManager>().AddScore();
        Destroy(gameObject);
    }
    else if (other.CompareTag("Ground"))
    {
        FindObjectOfType<GameManager>().LoseLife();
        Destroy(gameObject);
    }
}
