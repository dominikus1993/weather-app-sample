<script lang="ts">
  let count: number = 0
  let name = "dupa"
  const increment = () => {
    count += 1
  }
</script>

<button on:click={increment}>
  count is {count}
  hello {name}
</button>
