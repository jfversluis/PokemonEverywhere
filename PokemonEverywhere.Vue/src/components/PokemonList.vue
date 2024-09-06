<template>
  <div>
    <h1>Pokémon</h1>
    <p v-if="loading"><em>Loading...</em></p>
    <ul v-else class="card-list">
      <li v-for="pokemon in pokemons" :key="pokemon.id" class="card-item">
        <img class="card-image" :src="pokemon.image.hires" />
        <div class="card-content">
          <h2>{{ pokemon.name.english }}</h2>
          <p>{{ pokemon.species }}</p>
        </div>
      </li>
    </ul>
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from 'vue';
import { Pokemon } from '../models/Pokemon';

export default defineComponent({
  name: 'PokemonList',
  setup() {
    let pokemons = ref<Pokemon[]>([]);
    let loading = ref(true);

    function handlePokemons(event: any) {
      const parsedPokenmons = JSON.parse(event.detail.message);
      pokemons.value = parsedPokenmons;
      loading.value = false;
    }

    window.addEventListener('HybridWebViewMessageReceived', handlePokemons);

    return {
      pokemons,
      loading,
    };
  },
});


</script>

<style scoped>
.card-list {
  list-style-type: none;
  padding: 0;
}

.card-item {
  display: flex;
  flex-direction: column;
  align-items: center;
  margin: 10px;
}

.card-image {
  width: 150px;
  height: 150px;
}

.card-content {
  text-align: center;
}
</style>